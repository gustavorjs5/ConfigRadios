using GodSharp.SerialPort.Helper;
using System;
using System.Text;

// ReSharper disable RedundantArgumentDefaultValue
namespace GodSharp.SerialPort.ConsoleSample
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.Write("input serialport name:");
            string read = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(read))
            {
                Exit();
            }

            GodSerialPort gsp = new GodSerialPort(x=> {
                x.PortName = read;
            });

            gsp.UseDataReceived(true,(sp,bytes) => {
                if (bytes!=null&&bytes.Length>0)
                {
                    string buffer = string.Join(" ", bytes);
                    var hex = BitConverter.ToString(bytes).Replace("-","");
                    var binary = Convert.ToString(Convert.ToInt64(hex, 16), 2);
                    string str = Encoding.Default.GetString(bytes,0,1);
                
                    //StringBuilder hex2 = new StringBuilder(1 * 2);
                 
                    //    hex2.AppendFormat("{0:x2}", bytes[3]);
                    //var b = hex2.ToString();
                    var c = new StringBuilder(1 * 2).AppendFormat("{0:x2}", bytes[3]).ToString();

                    var baudiosbinary = Convert.ToString(Convert.ToInt64(c, 16), 2);
                    int index = (baudiosbinary.Length / 2);
                    var baudio = baudiosbinary.Substring(0, index);
                    var baudioR = baudiosbinary.Substring(index, baudiosbinary.Length-2);
                    int s =  UartBaud.getUartBaud(Convert.ToInt32(baudio));
                    var a = UartBaud.getAir(Convert.ToInt32(baudioR));
                    // string byte4 =BitConverter.ToString(b);
                    Console.WriteLine("receive data:" + binary.ToString());
                    Console.WriteLine("receive data:" + str.ToString());
                    Console.WriteLine("receive data:" + BitConverter.ToString(bytes).Replace("-", " "));
                    Console.WriteLine("receive data:" + Convert.ToString(Convert.ToInt64(c, 16), 2));
                }
            });

            bool flag = gsp.Open();

            if (!flag)
            {
                Exit();
            }

            Console.WriteLine("serialport opend");

            Console.WriteLine("press any thing as data to send,press key 'q' to quit.");

            string data = null;
            while (data == null || data.ToLower()!="q")
            {
                if (!string.IsNullOrEmpty(data))
                {
                    Console.WriteLine("send data:"+data);
                    gsp.WriteHexString(data);
                }
                data = Console.ReadLine();
            }
        }

        static void Exit()
        {
            Console.WriteLine("press any key to quit.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
