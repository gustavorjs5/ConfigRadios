using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GodSharp.SerialPort.Helper
{
  public static class UartBaud
    {
        private static Dictionary<int, int> Baud = new Dictionary<int, int>()
                                            {
                                                {0,1200},
                                                {1, 2400},
                                                {10,4800},
                                                {11,9600},
                                                {100,19200},
                                                {101,38400},
                                                {110,57600},
                                                {111,115200},


                                            };
        private static Dictionary<int, string> Air = new Dictionary<int, string>()
                                            {
                                                {0,"0.3 K"},
                                                {1, "1.2 K"},
                                                {10,"2.4 K"},
                                                {11,"4.8 K"},
                                                {100,"9.6 K"},
                                                {101,"19.2 k"}

                                            };


        private static Dictionary<string, int> MHZ = new Dictionary<string, int>()
                                            {
                                                        {"00",410},
                                                        {"01",411},
                                                        {"02",412},
                                                        {"03",413},
                                                        {"04",414},
                                                        {"05",415},
                                                        {"06",416},
                                                        {"07",417},
                                                        {"08",418},
                                                        {"09",419},
                                                        {"0A",420},
                                                        {"0B",421},
                                                        {"0C",422},
                                                        {"0D",423},
                                                        {"0E",424},
                                                        {"0F",425},
                                                        {"10",426},
                                                        {"11",427},
                                                        {"12",428},
                                                        {"13",429},
                                                        {"14",430},
                                                        {"15",431},
                                                        {"16",432},
                                                        {"17",433},
                                                        {"18",434},
                                                        {"19",435},
                                                        {"1A",436},
                                                        {"1B",437},
                                                        {"1C",438},
                                                        {"1D",439},
                                                        {"1E",440},
                                                        {"1F",441}

                                            };


        public  static int getUartBaud(int index){

            Baud.TryGetValue(index, out index);
            return index;

        }

        public static string getAir(int index)
        {
            string value=String.Empty;

            Air.TryGetValue(index, out value);
            return value;

        }

  
        public static List<KeyValuePair<int,int>> getDBaud()
        {

            return Baud.ToList();

        }
        public static List<KeyValuePair<int, string>> getListAir()
        {

            return Air.ToList();

        }

        public static List<KeyValuePair<string, int>> getListMHZ()
        {

            return MHZ.ToList();

        }


    }

}
