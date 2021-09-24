using GodSharp.SerialPort;
using GodSharp.SerialPort.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFEnlaces.TerminalSerie
{
    public partial class Inicio : Form
    {
        public Form1 f_form1 { get; set; }
        public GodSerialPort gsp { get; set; }
        public int ValueRF { get; set; }
        Form1 fr2 = new Form1();
        public Inicio(Form1 form1)
        {
            InitializeComponent();
            f_form1 = form1;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            GodSerialPort.GetPortNames();
            btnLeer.Enabled = false;
            btnEscribir.Enabled = false;
            btnDesconectar.Enabled = false;
            port.DataSource = GodSerialPort.GetPortNames(); 
            port.SelectedIndex = 0;
            port.DropDownStyle = ComboBoxStyle.DropDownList;
            RFRate.DropDownStyle = ComboBoxStyle.DropDownList;
            RateSerial.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMHZ.DropDownStyle = ComboBoxStyle.DropDownList;

            Panel objMenuVertical = (Panel)fr2.Controls["MenuVertical"];

            //Accedemos al control de la colección Items del contenedor ToolStrip. 
            objMenuVertical.BackColor = Color.White;

            objMenuVertical.Refresh();



        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           gsp = new GodSerialPort(x => {
                x.PortName = port.SelectedItem.ToString();
            });

            bool flag = gsp.Open();

            if (!flag)
            {
                Exit();
            }
            btnDeconectado.Text = "Conectado";
            btnDeconectado.BackColor = Color.Green;
            btnLeer.Enabled = true;
            button1.Enabled = false;
            btnEscribir.Enabled = true;
            btnDesconectar.Enabled = true;
            //var f= f_form1.Controls["pictureBox2"];
            //MessageBox.Show();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
        static void Exit()
        {
            
            MessageBox.Show("Error al conectar puerto");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            gsp.Close();
            button1.Enabled = true;
            RFRate.DataSource=null;
            RateSerial.DataSource = null;
            comboBoxMHZ.DataSource = null;
            btnDeconectado.Text = "Desconectado";
            btnDeconectado.BackColor = Color.Red;
            btnLeer.Enabled = false;
            btnEscribir.Enabled = false;
            btnDesconectar.Enabled = false;
        }
        
        private  void Button4_Click(object sender, EventArgs e)
        {
            gsp.WriteHexString("C1 C1 C1");

            gsp.UseDataReceived(true, UseDataReceived);
            //    gsp.UseDataReceived(true, (sp, bytes) => {
            //    if (bytes != null && bytes.Length > 0)
            //    {
            //        RFRate.DataSource = UartBaud.getDBaud();
            //        RFRate.DisplayMember = "value";
            //        RFRate.ValueMember = "key";

            //        RFPower.DataSource = UartBaud.getListAir();
            //        RFPower.DisplayMember = "value";
            //        RFPower.ValueMember = "key";

            //        comboBoxMHZ.DataSource = UartBaud.getListMHZ();
            //        comboBoxMHZ.DisplayMember = "value";
            //        comboBoxMHZ.ValueMember = "key";


            //        string buffer = string.Join(" ", bytes);
            //        var hex = BitConverter.ToString(bytes).Replace("-", "");
            //        var binary = Convert.ToString(Convert.ToInt64(hex, 16), 2);
            //        string str = Encoding.Default.GetString(bytes, 0, 1);

            //        //StringBuilder hex2 = new StringBuilder(1 * 2);

            //        //    hex2.AppendFormat("{0:x2}", bytes[3]);
            //        //var b = hex2.ToString();
            //        var c = new StringBuilder(1 * 2).AppendFormat("{0:x2}", bytes[3]).ToString();
            //        var mhzHex = new StringBuilder(1 * 2).AppendFormat("{0:x2}", bytes[4]).ToString();
            //        this.comboBoxMHZ.SelectedValue = mhzHex;
            //        var baudiosbinary = Convert.ToString(Convert.ToInt64(c, 16), 2);
            //        int index = (baudiosbinary.Length / 2);
            //        var baudio = baudiosbinary.Substring(0, index);
            //        ValueRF =Convert.ToInt32( baudiosbinary.Substring(index, baudiosbinary.Length - 2));
            //        this.RFRate.SelectedValue = Convert.ToInt32(baudio);
            //        this.RFPower.SelectedValue = Convert.ToInt32(ValueRF);
            //        int s = UartBaud.getUartBaud(Convert.ToInt32(baudio));
            //      //  var a = UartBaud.getAir(Convert.ToInt32(baudioR));
            //        // string byte4 =BitConverter.ToString(b);
            //        Console.WriteLine("receive data:" + binary.ToString());
            //        Console.WriteLine("receive data:" + str.ToString());
            //        Console.WriteLine("receive data:" + BitConverter.ToString(bytes).Replace("-", " "));
            //        Console.WriteLine("receive data:" + Convert.ToString(Convert.ToInt64(c, 16), 2));
            //    }
            //});

          

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void UseDataReceived(GodSerialPort sp, byte[] bytes) {

            if (bytes != null && bytes.Length > 0)
            {
                RateSerial.DataSource = UartBaud.getDBaud();
                RateSerial.DisplayMember = "value";
                RateSerial.ValueMember = "key";

                RFRate.DataSource = UartBaud.getListAir();
                RFRate.DisplayMember = "value";
                RFRate.ValueMember = "key";

                comboBoxMHZ.DataSource = UartBaud.getListMHZ();
                comboBoxMHZ.DisplayMember = "value";
                comboBoxMHZ.ValueMember = "key";


                string buffer = string.Join(" ", bytes);
                var hex = BitConverter.ToString(bytes).Replace("-", "");
                var binary = Convert.ToString(Convert.ToInt64(hex, 16), 2);
                string str = Encoding.Default.GetString(bytes, 0, 1);

                //StringBuilder hex2 = new StringBuilder(1 * 2);

                //    hex2.AppendFormat("{0:x2}", bytes[3]);
                //var b = hex2.ToString();
                var c = new StringBuilder(1 * 2).AppendFormat("{0:x2}", bytes[3]).ToString();
                var mhzHex = new StringBuilder(1 * 2).AppendFormat("{0:x2}", bytes[4]).ToString();
                this.comboBoxMHZ.SelectedValue = mhzHex.ToUpper();
                var baudiosbinary = Convert.ToString(Convert.ToInt64(c, 16), 2).PadLeft(6, '0');
                var lend = baudiosbinary.Length ;
                var lstar = baudiosbinary.Length - 3;

                var v = baudiosbinary.Substring(lstar, 3);
                var x = baudiosbinary.Substring(0, 3);
                int index = (baudiosbinary.Length /2);
                int RateSerialv = 0;
                int RFRatev = 0;
                //if (baudiosbinary.Length > 3){ 
                //if (index == 0){
                //     RateSerialv = Convert.ToInt32(baudiosbinary.Substring(0, 1));
                //     RFRatev = Convert.ToInt32(baudiosbinary.Substring(index, 1));
                //}
                //else
                //{
                //    var strs = baudiosbinary.Insert(index, "-").Split('-');
                //    RateSerialv = Convert.ToInt32(strs[0]);
                //     RFRatev = Convert.ToInt32(strs[1]);
                //}

                //}
                //else
                //{
                //    RateSerialv = Convert.ToInt32(0);
                //    RFRatev = Convert.ToInt32(baudiosbinary);
                //}
                RateSerialv = Convert.ToInt32(x);
                RFRatev = Convert.ToInt32(v);
                this.RateSerial.SelectedValue = Convert.ToInt32(RateSerialv);
                this.RFRate.SelectedValue = Convert.ToInt32(RFRatev);
                //int s = UartBaud.getUartBaud(Convert.ToInt32(baudio));
                //  var a = UartBaud.getAir(Convert.ToInt32(baudioR));
                // string byte4 =BitConverter.ToString(b);
                Console.WriteLine("receive data:" + binary.ToString());
                Console.WriteLine("receive data:" + str.ToString());
                Console.WriteLine("receive data:" + BitConverter.ToString(bytes).Replace("-", " "));
                Console.WriteLine("receive data:" + Convert.ToString(Convert.ToInt64(c, 16), 2));
            }
            }

        private void Button3_Click(object sender, EventArgs e)
        {
            var g = RateSerial.SelectedValue.ToString().PadLeft(3, '0');
            var r=RFRate.SelectedValue.ToString().PadLeft(3, '0');
            var concat = g+r;
            var c =comboBoxMHZ.SelectedValue;

            string valorHexa = string.Format("{0:x}", Convert.ToInt32(concat, 2)).ToUpper().PadLeft(2, '0');

            string write = "C0 00 00 " + valorHexa  + " " + c + " 40";

            //GodSerialPort gsp2 = new GodSerialPort(x => {
            //    x.PortName = port.SelectedItem.ToString();
            //});
            //gsp2.Open();
            gsp.WriteHexString(write);
            gsp.UseDataReceived(true, UseDataReceivedWrite);
            //gsp2.UseDataReceived(true, (sp, bytes) => {
            //    if (bytes != null && bytes.Length > 0)
            //    {
            //        string buffer = string.Join(" ", bytes);
            //    }
            //});


        }

        private void UseDataReceivedWrite(GodSerialPort arg1, byte[] arg2)
        {
            string buffer =Encoding.ASCII.GetString( arg2).Substring(0,2);

             if(buffer == "OK"){
                MessageBox.Show("Se registro correctamente");

            }
            else
            {
                MessageBox.Show("ERROR: No se registro.");

            }

        }
    }
}
