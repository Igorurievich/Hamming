using System;
using System.Windows.Forms;
using System.Text;
using System.Linq;
using Projekt_Surtel;

namespace Projekt_Teleinf
{
    public partial class Form1 : Form
    {
        HammingCode Hamming = new HammingCode();
        HammingCode SecondHamming = new HammingCode();
        string Hamming_code = string.Empty;
        string msg_hash;
        string msg_temp;
        int crc = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            tb_Binary_message.Text = string.Empty;
            tb_CRC.Text = string.Empty;
            tb_Message_and_CRC.Text = string.Empty;
            tb_Hammings_code.Text = string.Empty;


            string bin_msg = string.Empty;
            msg_hash = string.Empty;
            string msg_and_hash = string.Empty;

            string message = tbMsg.Text;


            Hamming.GetMessage(tbMsg.Text);

            

            //bin_msg = message;

            //byte[] buff = Encoding.ASCII.GetBytes(bin_msg);
            byte[] HashBytes = new byte[] { };

            if (cmbCRC.SelectedItem.ToString() == "16")
            {
                Crc16 CRC16 = new Crc16();
                HashBytes = CRC16.ComputeChecksumBytes(Encoding.ASCII.GetBytes(Hamming.Message.ToString()));
                crc = 16;
            }
            else if (cmbCRC.SelectedItem.ToString() == "32")
            {
                Crc32 CRC32 = new Crc32();
                HashBytes = CRC32.ComputeChecksumBytes(Encoding.ASCII.GetBytes(Hamming.Message.ToString()));
                crc = 32;
            }

            Hamming.Message.Append(string.Join(null, HashBytes.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray()));
            Hamming.CalculateControlBitsCount();
            Hamming.CalculateControlBitsPosition();
            Hamming.InsertControlBitsInPosition();
            Hamming.InitializeOrdinalDigits();
            Hamming.InitializeMatrix();
            Hamming.CalculateControlBits();
            tb_syndrome.Text = Hamming.Syndrome.ToString();
            Hamming.CodeMessage();

            tb_Hammings_code.Text = Hamming.Message.ToString();

            //FirstHamming.CalculateControlBitsCount(msg_and_hash);
            //tb_Message_and_CRC.Text = msg_and_hash;
            //FirstHamming.CalculateControlBitsPosition(FirstHamming.controlBitsCount);
            //msg_and_hash = FirstHamming.InsertControlBitsInPosition(msg_and_hash);

            //FirstHamming.matrix = new string[FirstHamming.controlBitsCount, msg_and_hash.Length];

            //FirstHamming.BinaryNumbers = new string[msg_and_hash.Length];

            // FirstHamming.InitializeOrdinalDigits(FirstHamming.BinaryNumbers, msg_and_hash);
            //FirstHamming.InitializeMatrix(FirstHamming.BinaryNumbers, FirstHamming.matrix);


            //FirstHamming.mask = FirstHamming.CalculateControlBits(msg_and_hash, FirstHamming.Matrix);

            //Hamming_code = FirstHamming.CodeMessage(msg_and_hash);
            
            //Hamming.CodeMessage();
            //tb_Hammings_code.Text = Hamming.Message.ToString();
            //char[] charArr = FirstHamming.Syndrome.ToCharArray();
            //Array.Reverse(charArr);
            //string tmp_first = new string(charArr);
            //int first = Convert.ToInt32(tmp_first, 2);


            //tb_Binary_message.Text = bin_msg;
            //tb_Hammings_code.Text = Hamming_code;
            //tb_CRC.Text = msg_hash;
            //tb_syndrome.Text = FirstHamming.mask;
            ////MessageBox.Show(first.ToString());


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCRC.SelectedIndex = 0;
            tbMsg.MaxLength = 80;
        }

        private void cmbCRC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRecalc_Click(object sender, EventArgs e)
        {
            tb_Hammings_with_errors.Text = string.Empty;
            tb_Hamming_after_checking.Text = string.Empty;

            Hamming.GetMessage(tbMsg.Text);

            //FirstHamming.msg = Hamming_code;
            //if (nupd_first_error.Value > 0 && nupd_second_error.Value > 0)
            //{
            //    Hamming_code = FirstHamming.InsertError(Convert.ToInt32(nupd_first_error.Value) - 1, Convert.ToInt32(nupd_second_error.Value) - 1);
            //}
            //else if (nupd_first_error.Value > 0 && nupd_second_error.Value == 0)
            //{
            //    Hamming_code = FirstHamming.InsertError(Convert.ToInt32(nupd_first_error.Value) - 1);
            //}

            //tb_Hammings_with_errors.Text = Hamming_code;

            //FirstHamming.matrixsecond = new string[FirstHamming.controlBitsCount, Hamming_code.Length];
            //FirstHamming.BinaryNumbersSecond = new string[Hamming_code.Length];
            //FirstHamming.InitializeOrdinalDigits(FirstHamming.BinaryNumbersSecond, Hamming_code);
            //FirstHamming.InitializeMatrix(FirstHamming.BinaryNumbersSecond, FirstHamming.matrixsecond);

            //FirstHamming.secmask = FirstHamming.CalculateControlBits(FirstHamming.msg, FirstHamming.matrixsecond);


            //char[] charArray = Hamming.secmask.ToCharArray();
            //Array.Reverse(charArray);
            //string tmp_second = new string(charArray);

            //int second = Convert.ToInt32(tmp_second, 2);


            //if (second>0)
            //{
            //    MessageBox.Show("Error on position: " + second + " trying to fix...");
            //    //Hamming_code = Hamming.FixError(Hamming_code, second - 1);
            //}
            //tb_Hamming_after_checking.Text = Hamming_code;

            ////tb_error_syndrome.Text = Hamming.secmask;
            ////MessageBox.Show("Error was fixed");
            //msg_temp = Hamming_code;
            ////Hamming_code = Hamming.DecodeMessage(Hamming_code);
            //tb_Decoded_Message_and_CRC.Text = Hamming_code;

            //string decodedHash = Hamming_code.Substring(Hamming_code.Length - crc);
            //string decodedMsg = Hamming_code.Substring(0, Hamming_code.Length - crc);

            ////decodedMsg = Hamng.GetMessage(decodedMsg);


            //byte[] byteArray = Encoding.ASCII.GetBytes(decodedMsg);


            //byte[] secondHash = new byte[] { };
            //if (crc == 16)
            //{
            //    Crc16 crc_16 = new Crc16();
            //    secondHash = crc_16.ComputeChecksumBytes(byteArray);
            //}
            //else if (crc == 32)
            //{
            //    Crc32 crc_32 = new Crc32();
            //    secondHash = crc_32.ComputeChecksumBytes(byteArray);
            //}
            //string[] hash = secondHash.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();
            //string secondHashStr = string.Empty;

            //foreach (var item in hash)
            //{
            //    secondHashStr += item;
            //}
            //tb_crc_end.Text = secondHashStr;
            //if (secondHashStr == msg_hash)
            //{
            //    MessageBox.Show("Message without error");
            //}
            //else
            //{
            //    MessageBox.Show("CRC do not match, error in message");
            //}
            //Hamming_code = msg_temp;
        }
    }
}
