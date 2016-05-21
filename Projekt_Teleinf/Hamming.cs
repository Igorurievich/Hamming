using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Surtel
{
    class HammingCode
    {
        public string[,] matrix;
        public string[,] matrixsecond;
        public int controlBitsCount;
        public int[] controlBitsPosition;
        public string mask;
        public string secmask;
        public string[] BinaryNumbers;
        public string[] BinaryNumbersSecond;
        public string msg;
        public string err_msg;
        public int errorPosition_1;
        public int errorPoisition_2;
        public int first;
        public int second;

        public HammingCode(string msg)
        {

        }

        public HammingCode()
        {
        }

        public string GetMessage(string msg)
        {
            //msg = Console.ReadLine();
            byte[] buff = Encoding.ASCII.GetBytes(msg);
            string[] msgtmp = buff.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();

            msg = String.Empty;
            foreach (var item in msgtmp)
            {
                //foreach (var itemIn in item)
                //{
                //    Console.Write(itemIn + " ");
                //}
                msg += item;
            }
            //Console.WriteLine();
            return msg;
        }
        public void CalculateControlBitsCount(string msg)
        {
            if (msg.Length == 1)
            {
                this.controlBitsCount = 2;
            }
            else
            {
                controlBitsCount = Convert.ToInt16(Math.Ceiling(Math.Log(Convert.ToDouble(msg.Length + 5), 2)));
            }
        }
        public void CalculateControlBitsPosition(int controlBitsCount)
        {
            controlBitsPosition = new int[controlBitsCount];
            for (int i = 0; i <= controlBitsCount - 1; i++)
            {
                controlBitsPosition[i] = Convert.ToInt32(Math.Pow(Convert.ToDouble(2), Convert.ToDouble(i)));
            }
        }
        public string InsertControlBitsInPosition(string msg)
        {
            for (int i = 0; i < controlBitsPosition.Length; i++)
            {
                msg = msg.Insert(controlBitsPosition[i] - 1, "0");
            }
            return msg;
        }
        public void InitializeOrdinalDigits(string[] BinaryNumbers, string msg)
        {
            
            for (int j = 0; j < msg.Length; j++)
            {
                BinaryNumbers[j] = Convert.ToString(j + 1, 2).PadLeft(controlBitsCount, '0');
                char[] inputarray = BinaryNumbers[j].ToCharArray();
                Array.Reverse(inputarray);
                BinaryNumbers[j] = new string(inputarray);
            }
            this.msg = msg;
        }
        public void InitializeMatrix(string[] BinNum, string[,] matr)
        {
            for (int i = 0; i < msg.Length; i++)
            {
                var tmp = BinNum[i].ToCharArray();
                for (int j = 0; j < controlBitsCount; j++)
                {
                    matr.SetValue(tmp[j].ToString(), j, i);
                }
            }
        }
        public string CalculateControlBits(string message, string[,] mtrx)
        {
            string msk = string.Empty;
            for (int i = 0; i < controlBitsCount; i++)
            {
                int flag = 0;
                for (int j = 0; j < msg.Length; j++)
                {
                    flag += Int32.Parse(message[j].ToString()) * Int32.Parse(mtrx.GetValue(i, j).ToString());
                }
                flag = flag % 2;
                msk += flag.ToString();
            }
            return msk;
        }
        public string CodeMessage(string msg)
        {
            for (int i = 0; i < controlBitsPosition.Length; i++)
            {
                msg = msg.Remove(controlBitsPosition[i] - 1, 1);
                msg = msg.Insert(controlBitsPosition[i] - 1, mask[i].ToString());
            }
            //foreach (var item in msg)
            //{
            //    Console.Write(item + " ");
            //}
            return msg;
        }
        public string InsertError(params int[] markPosition)
        {
            var tmp = msg.ToList();
            msg = string.Empty;
            for (int i = 0; i < markPosition.Length; i++)
            {
                if (tmp[markPosition[i]] == '0')
                {
                    tmp[markPosition[i]] = '1';
                }
                else if (tmp[markPosition[i]] == '1')
                {
                    tmp[markPosition[i]] = '0';
                }
                msg = string.Empty;
                foreach (var item in tmp)
                {
                    msg += item;
                }
            }
            return msg;
        }
        public string FixError(string msg, int errorPosition)
        {
            var tmp = msg.ToList();
            if (msg[errorPosition] == '0')
            {
                tmp[errorPosition] = '1';
            }
            else if (msg[errorPosition] == '1')
            {
                tmp[errorPosition] = '0';
            }
            msg = string.Empty;
            foreach (var item in tmp)
            {
                msg += item;
            }

            return msg;
        }
        static bool Is_exp(int n)
        {
            //if (n == 0)
            //{
            //    return false;
            //}
            //else
            {
                return (n & (n - 1)) == 0;
            }
        }
        public string DecodeMessage(string mess)
        {
            List<char> msg = new List<char>();
            //for (int i = 0; i < controlBitsPosition.Length; i++)
            //{
            //    //mess = mess.Remove(controlBitsPosition[i]-1, 1);
            //    msg[i] = mess[i];
            //}

            for (int i = 0; i <= mess.Length; i++)
            {
                if (!Is_exp(i))
                {
                    if (i == 0)
                    {
                        msg.Add(mess[i]);
                        continue;
                    }
                    msg.Add(mess[i - 1]);
                }
            }
            string tmp = string.Empty;
            foreach (var item in msg)
            {
                tmp += item.ToString();
            }
            return tmp;
        }
    }
}
