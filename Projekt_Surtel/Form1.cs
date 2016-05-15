using System;
using System.Windows.Forms;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Projekt_Teleinf;
using System.ComponentModel;

namespace Projekt_Teleinf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbcrc16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            tb_Binary_message.Text = String.Empty;
            tb_CRC.Text = String.Empty;
            tb_Message_and_CRC.Text = String.Empty;
            tb_Hammings_code.Text = String.Empty;
            string message = tbMsg.Text;
            byte[] buff = Encoding.ASCII.GetBytes(message);
            byte[] hash = new byte[] { };

            if (cmbCRC.SelectedItem.ToString() == "16")
            {
                Crc16 crc_16 = new Crc16();
                hash = crc_16.ComputeChecksumBytes(buff);
            }
            else if (cmbCRC.SelectedItem.ToString() == "32")
            {
                Crc32 crc_32 = new Crc32();
                hash = crc_32.ComputeChecksumBytes(buff);
            }

            string[] b = hash.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();
            string[] msg = buff.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();


            List<string> msg_crc = new List<string>(msg);
            msg_crc.AddRange(b);


            foreach (var item in msg_crc)
            {
                tb_Message_and_CRC.AppendText(item + " ");
            }

            for (int i = 0; i < msg.Length; i++)
            {
                tb_Binary_message.AppendText(msg[i] + " ");
            }

            for (int i = 0; i < b.Length; i++)
            {
                tb_CRC.AppendText(b[i] + " ");
            }
            getHamming(msg_crc.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCRC.SelectedIndex = 0;
            tbMsg.MaxLength = 80;
        }

        private void cmbCRC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void getHamming(string[] msg)
        {
            Binary message;

            string rawMessage = String.Empty;

            for (int i = 0; i < msg.Length; i++)
            {
                rawMessage += msg[i];
            }
            message = new Binary(rawMessage.Select(c => c == '1' ? true : false));

            int columnsAmount = message.Count();
            int rowsAmount = (int)Math.Ceiling(Math.Log(columnsAmount, 2) + 1);

            BinaryMatrix H = GenerateHMatrix(rowsAmount, columnsAmount);
            Binary verification = GenerateVerificationBits(H, message);
            Binary frame = Binary.Concatenate(message, verification);

            Binary temp = new Binary(message);

            for (int i = 0; i < verification.Length; i++)
            {
                if (i == 0)
                {
                    temp.binary.Insert(1, verification.binary[i]);
                }
                if (i == 1)
                {
                    temp.binary.Insert(2, verification.binary[i]);
                }
                if (i == 2)
                {
                    temp.binary.Insert(4, verification.binary[i]);
                }
                if (i == 3)
                {
                    temp.binary.Insert(8, verification.binary[i]);
                }
                if (i == 4)
                {
                    temp.binary.Insert(16, verification.binary[i]);
                }
                if (i == 5 && temp.binary.Capacity > 32)
                {
                    temp.binary.Insert(32, verification.binary[i]);
                }
            }
 
            for (int i = 1; i < temp.Length; i++)
            {
                tb_Hammings_code.AppendText((Convert.ToInt32(temp.binary[i-1])).ToString());
                if (i % 8 == 0) 
                {
                    tb_Hammings_code.AppendText(" ");
                }
                
            }
        }
        private static int FindFaultyBit(BinaryMatrix H, Binary s)
        {
            for (int i = 0; i < H.ColumnAmount; i++)
            {
                Binary column = H.GetColumn(i);
                Binary check = s ^ column;
                if (check.Any(b => b))
                    continue;
                return i;
            }

            throw new WarningException("Faulty bit not found!");
        }
        static BinaryMatrix GenerateHWithIdentity(BinaryMatrix H)
        {
            BinaryMatrix HWithIdentity = new BinaryMatrix(H.RowAmount, H.ColumnAmount + H.RowAmount);
            for (int y = 0; y < H.RowAmount; y++)
            {
                for (int x = 0; x < H.ColumnAmount; x++)
                {
                    HWithIdentity.Set(y, x, H.Get(y, x));
                }
            }

            for (int y = 0; y < H.RowAmount; y++)
            {
                int n = 0;
                for (int x = H.ColumnAmount; x < H.ColumnAmount + H.RowAmount; x++)
                {
                    HWithIdentity.Set(y, x, y == n);

                    n++;
                }
            }
            return HWithIdentity;
        }
        static Binary GenerateVerificationBits(BinaryMatrix H, Binary message)
        {
            Binary verification = new Binary(new bool[H.RowAmount]);
            for (int i = 0; i < H.RowAmount; i++)
            {
                Binary row = H.GetRow(i);
                Binary addiction = row & message;
                bool verificationBit = addiction.CountOnes() % 2 == 1 ? true : false;
                verification[i] = verificationBit;
            }
            return verification;
        }
        static BinaryMatrix GenerateHMatrix(int rowsAmount, int columnsAmount)
        {
            BinaryMatrix H = new BinaryMatrix(rowsAmount, columnsAmount);

            int n = 0;
            for (int i = 1; i <= Math.Pow(2, rowsAmount); i++)
            {
                Binary binary = new Binary(i, H.RowAmount);
                if (binary.CountOnes() >= 2)
                {
                    for (int y = 0; y < rowsAmount; y++)
                    {
                        H.Set(y, n, binary[y]);
                    }
                    n++;
                }
                if (n >= H.ColumnAmount)
                    break;
            }
            return H;
        }
    }
}
