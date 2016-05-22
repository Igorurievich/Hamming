using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Surtel
{
    static class Extentions
    {
        static private StringBuilder ReverseStringImpl(string s, int pos, StringBuilder sb)
        {
            return (s.Length <= --pos || pos < 0) ? sb : ReverseStringImpl(s, pos, sb.Append(s[pos]));
        }

        static public string Reverse(this string s)
        {
            return ReverseStringImpl(s, s.Length, new StringBuilder()).ToString();
        }
    }
    class HammingCode
    {
        public string[,] Matrix { get; set; }
        //public string[,] matrixsecond;
        public int controlBitsCount;
        public int[] ControlBitsPosition { get; set; }
        public string Syndrome { get; set; }
        //public string secmask;
        public string[] BinaryNumbers { get; set; }
        //public string[] BinaryNumbersSecond;
        public StringBuilder Message { get; set; }
        public int[] MarkPositions { get; set; }
        public int ErrorPosition { get; set; }


        public HammingCode(string msg)
        {

        }

        public HammingCode()
        {
        }

        /// <summary>
        /// Get the message for encoding.
        /// </summary>
        /// <param name="message"></param>
        public void GetMessage(string message)
        {
            Message = new StringBuilder();
            byte[] buff = Encoding.ASCII.GetBytes(message);
            string[] msgtmp = buff.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')).ToArray();
            Message.Append(string.Join(null, msgtmp));
        }
        /// <summary>
        /// Calculate control bits count from length the message.
        /// </summary>
        public void CalculateControlBitsCount()
        {
            if (Message.Length == 1)
            {
                this.controlBitsCount = 2;
            }
            else
            {
                controlBitsCount = Convert.ToInt16(Math.Ceiling(Math.Log(Convert.ToDouble(Message.Length + 5), 2)));
            }
        }
        /// <summary>
        /// Calculate the positions for control bits.
        /// </summary>
        public void CalculateControlBitsPosition()
        {
            ControlBitsPosition = new int[this.controlBitsCount];
            for (int i = 0; i <= controlBitsCount - 1; i++)
            {
                ControlBitsPosition[i] = Convert.ToInt32(Math.Pow(Convert.ToDouble(2), Convert.ToDouble(i)));
            }
        }
        /// <summary>
        /// Inserting control zeros in message. 
        /// </summary>
        public void InsertControlBitsInPosition()
        {
            for (int i = 0; i < controlBitsCount; i++)
            {
                    Message.Insert(ControlBitsPosition[i] - 1, '0');
            }
        }
        /// <summary>
        /// Initialize digits in binary represenation
        /// </summary>
        public void InitializeOrdinalDigits()
        {
            BinaryNumbers = new string[Message.Length];
            for (int j = 0; j < Message.Length; j++)
            {
                BinaryNumbers[j] = Convert.ToString(j + 1, 2).PadLeft(controlBitsCount, '0');
                char[] InputArray = BinaryNumbers[j].ToCharArray();
                Array.Reverse(InputArray);
                BinaryNumbers[j] = new string(InputArray);
            }
        }
        /// <summary>
        /// Initialize H-Matrix
        /// </summary>
        public void InitializeMatrix()
        {
            Matrix = new string[controlBitsCount,Message.Length];
            for (int i = 0; i < Message.Length; i++)
            {
                for (int j = 0; j < controlBitsCount; j++)
                {
                    Matrix.SetValue(BinaryNumbers[i].ToString(), j, i);
                }
            }
        }
        /// <summary>
        /// Need more time
        /// </summary>
        public void CalculateControlBits()
        {
            //for (int i = 0; i < controlBitsCount; i++)
            //{
            //    int ProductsSumm = 0;
            //    for (int j = 0; j < Message.Length; j++)
            //    {
            //        ProductsSumm += Int32.Parse(Message[j].ToString()) * Int32.Parse(Matrix.GetValue(i,j).ToString());
            //    }
            //    ProductsSumm %= 2;
            //    Syndrome += ProductsSumm.ToString();
            //}
            string msk = string.Empty;
            for (int i = 0; i < controlBitsCount; i++)
            {
                int flag = 0;
                for (int j = 0; j < Message.Length; j++)
                {
                    flag += Int32.Parse(Message[j].ToString()) * Int32.Parse(Matrix.GetValue(i, j).ToString());
                }
                flag = flag % 2;
                msk += flag.ToString();
            }
        }
        /// <summary>
        /// Insert control bits in message is delivered in advance of the zeros.
        /// </summary>
        public void CodeMessage()
        {
            for (int i = 0; i < ControlBitsPosition.Length; i++)
            {
                Message.Replace("0", Syndrome[i].ToString(), ControlBitsPosition[i] - 1, 1);
            }
        }
        public void InsertError(params int[] markPosition)
        {
            for (int i = 0; i < markPosition.Length; i++)
            {
                if (Message[MarkPositions[i]] == '0')
                {
                    Message[MarkPositions[i]] = '1';
                }
                else
                {
                    Message[MarkPositions[i]] = '0';
                }
            }
        }
        public void FixError()
        {
            if (Message[ErrorPosition] == '0')
            {
                Message[ErrorPosition] = '1';
            }
            else
            {
                Message[ErrorPosition] = '0';
            }
        }
        public bool Is_exp(int n)
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
        public void DecodeMessage()
        {
            for (int i = 0; i < ControlBitsPosition.Length; i++)
            {
                Message.Remove(ControlBitsPosition[i] - 1, 1);
            }




            //List<char> msg = new List<char>();
            ////for (int i = 0; i < controlBitsPosition.Length; i++)
            ////{
            ////    //mess = mess.Remove(controlBitsPosition[i]-1, 1);
            ////    msg[i] = mess[i];
            ////}

            //for (int i = 0; i <= mess.Length; i++)
            //{
            //    if (!Is_exp(i))
            //    {
            //        if (i == 0)
            //        {
            //            msg.Add(mess[i]);
            //            continue;
            //        }
            //        msg.Add(mess[i - 1]);
            //    }
            //}
            //string tmp = string.Empty;
            //foreach (var item in msg)
            //{
            //    tmp += item.ToString();
            //}
            //return tmp;
        }
    }
}
