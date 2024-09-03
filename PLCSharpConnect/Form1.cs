using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using MelsecPLC;

namespace PLCSharpConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            winsock1Connect();

            timer1.Enabled = true;
            timer1.Start();
        }
        private void winsock1Connect()
        {
            try
            {
                if (winsock1.GetState.ToString() != "Connected")
                {

                    winsock1.LocalPort = int.Parse(text_local_port.Text);

                    winsock1.RemoteIP = txtPLCIPAddress.Text.Trim();
                    // int a = 8000;

                    winsock1.RemotePort = int.Parse(text_remote_port.Text);

                    winsock1.Connect();
                }
            }
            catch (Exception ex)
            {
            }
        }

        string Jig01;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Jig01))
            {
                text_read_data.Text = Jig01;
            }
        }

        private void winsock1_DataArrival(MelsecPLC.Winsock sender, int BytesTotal)
        {
            String s = String.Empty;
            winsock1.GetData(ref s);
            Jig01 = s;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (winsock1.GetState.ToString() != "Connected")
                {

                    winsock1Connect();

                }
                if (winsock1.GetState.ToString() != "Connected")
                {
                    MessageBox.Show("Not Connected");
                    return;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            winsock1.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (winsock1.GetState.ToString() != "Connected")
            {
                winsock1Connect();
            }
            if (winsock1.GetState.ToString() != "Connected")
            {
                MessageBox.Show("Not Connected");
                return;
            }
                //String cmd = "500000FF03FF000018000A04010000D*0095000001";
                String cmd = "";
            String OutAddress = "0001";
            cmd = "";
            cmd = cmd + "5000";// sub HEAD (NOT)
            cmd = cmd + "00";//   network number (NOT)
            cmd = cmd + "FF";//PLC NUMBER
            cmd = cmd + "03FF";// DEMAND OBJECT MUDULE I/O NUMBER
            cmd = cmd + "00";//  DEMAND OBJECT MUDULE DEVICE NUMBER
            cmd = cmd + "001C";//  Length of demand data
            cmd = cmd + "000A";//  CPU inspector data
            cmd = cmd + "0401";//  Read command
            cmd = cmd + "0000";//  Sub command
            cmd = cmd + text_tag.Text;//   device code
            cmd = cmd + "009500"; //adBase 
            cmd = cmd + OutAddress;  //BASE ADDRESS           
            winsock1.Send(cmd);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (winsock1.GetState.ToString() != "Connected")
            {
                winsock1Connect();
            }
            if (winsock1.GetState.ToString() != "Connected")
            {
                MessageBox.Show("Not Connected");
                return;
            }

            String cmd = "";
            String OutAddress = txtWrite.Text.Trim();
            cmd = "";
            cmd = cmd + "5000";// sub HEAD (NOT)
            cmd = cmd + "00";//   network number (NOT)
            cmd = cmd + "FF";//PLC NUMBER
            cmd = cmd + "03FF";// DEMAND OBJECT MUDULE I/O NUMBER
            cmd = cmd + "00";//  DEMAND OBJECT MUDULE DEVICE NUMBER
            cmd = cmd + "001C";//  Length of demand data
            cmd = cmd + "000A";//  CPU inspector data
            cmd = cmd + "1401";//  Write command
            cmd = cmd + "0000";//  Sub command
            cmd = cmd + text_tag.Text;//   device code
            cmd = cmd + "009501"; //adBase 
            cmd = cmd + OutAddress;  //BASE ADDRESS
            winsock1.Send(cmd);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
