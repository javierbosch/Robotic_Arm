//By Javier Bosch, CTO, Deutsche Schule Sevilla//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Brazo
{
    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort();

        int[] sn = { 2000, 3000, 4000, 5000, 6000, 7000 };  //Values for each servo//


        int[] h = { 125, 95, 49, 112, 100, 104 };   //Home values

        int[] CeroArray = { 0, 0, 0, 0, 0, 0 }; //Possible position//--Haced todos los de estos que querais para preparar posiciones preestablecidas del brazo--//

        int MaxDegrees = 180;   //Maximun possible degrees for a servo//

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            port.PortName = "COM4"; //Output port name//--IMPORTANTE CHICOS, VARIA EN CADA PUERTO QUE SE CONECTE
                                    //EL NOMBRE DEL PUERTO SE PUEDE CONSULTAR DESDE ARDUINO. TENEIS QUE PONER EL PUERTO CORRECTO.--//
            port.BaudRate = 9600;
            try
            {
                port.Open();
            }
            catch { }
        }
        
        private void Pause(){
       		System.Threading.Thread.Sleep(100); //Wait for 0.1 seconds//

        }

        private void BaseServo_Scroll(object sender, EventArgs e)
        {
            if (port.IsOpen)  //Sees if the port is connected, if not, it wont response. Used along all the code//
            {
                int d = BS_trackBar.Value;  //Gets the trackbar degrees//
                string v = (d + sn[0]).ToString();  //Summ the degrees and the servo number indicator, convert it to string//
                port.WriteLine(v);  //Send the values to through the port (has to be a string)//
                BS_textBox.Text = d.ToString();
                Pause();
            }
        }
        private void ShoulderServo_Scroll(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                int d = SS_trackBar.Value;
                string v = (d + sn[1]).ToString();
                port.WriteLine(v);
                SS_textBox.Text = d.ToString();
                Pause();
            }
        }
        private void ElbowServo_Scroll(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                int d = ES_trackBar.Value;
                string v = (d + sn[2]).ToString();
                port.WriteLine(v);
                ES_textBox.Text = d.ToString();
                Pause();
            }
        }
        private void WristFlexServo(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                int d = WFS_trackBar.Value;
                string v = (d + sn[3]).ToString();
                port.WriteLine(v);
                WFS_textBox.Text = d.ToString();
                Pause();
            }
        }
        private void WristRotateServo_Scroll(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                int d = WRS_trackBar.Value;
                string v = (d + sn[4]).ToString();
                port.WriteLine(v);
                WRS_textBox.Text = d.ToString();
                Pause();
            }
        }
        private void GripperServo_Scroll(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                int d = GS_trackBar.Value;
                string v = (d + sn[5]).ToString();
                port.WriteLine(v);
                GS_textBox.Text = d.ToString();
                Pause();
            }
        }

        private void ProIU_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                if (panel1.Enabled == false)
                {
                    panel1.Enabled = true;
                    BS_textBox.Enabled = true;
                    SS_textBox.Enabled = true;
                    ES_textBox.Enabled = true;
                    WFS_textBox.Enabled = true;
                    WRS_textBox.Enabled = true;
                    GS_textBox.Enabled = true;
                }
                else
                {
                    panel1.Enabled = false;
                    BS_textBox.Enabled = false;
                    SS_textBox.Enabled = false;
                    ES_textBox.Enabled = false;
                    WFS_textBox.Enabled = false;
                    WRS_textBox.Enabled = false;
                    GS_textBox.Enabled = false;
                }
            }
        }

        private void BaseServo_KeyDown(object sender, KeyEventArgs e)
        {
            if (port.IsOpen)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int d;
                    bool IsANumber = Int32.TryParse(BS_textBox.Text, out d);

                    if (IsANumber)
                    {
                        if (d >= 0 && d <= 180) { }
                        else
                        {
                            d = h[0];
                            BS_textBox.Text = d.ToString();
                        }
                        BS_trackBar.Value = d;
                        string v = (d + sn[0]).ToString();
                        port.WriteLine(v);
                        Pause();
                    }
                    else if (BS_textBox.Text == "")
                    {
                        BS_textBox.Text = "0";
                    }
                    else
                    {
                        BS_textBox.Text = null;
                    }
                }
            }
        }

        private void ShoulderServo_KeyDown(object sender, KeyEventArgs e)
        {
            if (port.IsOpen)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int d;
                    bool IsANumber = Int32.TryParse(SS_textBox.Text, out d);

                    if (IsANumber)
                    {
                        if (d >= 0 && d <= 180) { }
                        else
                        {
                            d = h[1];
                            SS_textBox.Text = d.ToString();
                        }
                        SS_trackBar.Value = d;
                        string v = (d + sn[1]).ToString();
                        port.WriteLine(v);
                        Pause();
                    }
                    else if (SS_textBox.Text == "")
                    {
                        SS_textBox.Text = "0";
                    }
                    else
                    {
                        SS_textBox.Text = null;
                    }
                }
            }
        }

        private void ElbowServo_KeyDown(object sender, KeyEventArgs e)
        {
            if (port.IsOpen)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int d;
                    bool IsANumber = Int32.TryParse(ES_textBox.Text, out d);

                    if (IsANumber)
                    {
                        if (d >= 0 && d <= 180) { }
                        else
                        {
                            d = h[2];
                            ES_textBox.Text = d.ToString();
                        }
                        ES_trackBar.Value = d;
                        string v = (d + sn[2]).ToString();
                        port.WriteLine(v);
                        Pause();
                    }
                    else if (ES_textBox.Text == "")
                    {
                        ES_textBox.Text = "0";
                    }
                    else
                    {
                        ES_textBox.Text = null;
                    }
                }
            }
        }

        private void WristFlexServo_KeyDown(object sender, KeyEventArgs e)
        {
            if (port.IsOpen)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int d;
                    bool IsANumber = Int32.TryParse(WFS_textBox.Text, out d);

                    if (IsANumber)
                    {
                        if (d >= 0 && d <= 180) { }
                        else
                        {
                            d = h[3];
                            WFS_textBox.Text = d.ToString();
                        }
                        WFS_trackBar.Value = d;
                        string v = (d + sn[3]).ToString();
                        port.WriteLine(v);
                        Pause();
                    }
                    else if (WFS_textBox.Text == "")
                    {
                        WFS_textBox.Text = "0";
                    }
                    else
                    {
                        WFS_textBox.Text = null;
                    }
                }
            }
        }

        private void WristRotateServo_KeyDown(object sender, KeyEventArgs e)
        {
            if (port.IsOpen)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int d;
                    bool IsANumber = Int32.TryParse(WRS_textBox.Text, out d);

                    if (IsANumber)
                    {
                        if (d >= 0 && d <= 180) { }
                        else
                        {
                            d = h[4];
                            WRS_textBox.Text = d.ToString();
                        }
                        WRS_trackBar.Value = d;
                        string v = (d + sn[4]).ToString();
                        port.WriteLine(v);
                        Pause();
                    }
                    else if (WRS_textBox.Text == "")
                    {
                        WRS_textBox.Text = "0";
                    }
                    else
                    {
                        WRS_textBox.Text = null;
                    }
                }
            }
        }

        private void GripperServo_KeyDown(object sender, KeyEventArgs e)
        {
            if (port.IsOpen)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int d;
                    bool IsANumber = Int32.TryParse(GS_textBox.Text, out d);

                    if (IsANumber)
                    {
                        if (d >= 0 && d <= 180) { }
                        else
                        {
                            d = h[5];
                            GS_textBox.Text = d.ToString();
                        }
                        GS_trackBar.Value = d;
                        string v = (d + sn[5]).ToString();
                        port.WriteLine(v);
                        Pause();
                    }
                    else if (GS_textBox.Text == "")
                    {
                        GS_textBox.Text = "0";
                    }
                    else
                    {
                        GS_textBox.Text = null;
                    }
                }
            }
        }
        
        private void MoveTo(int[] p)
        {
            int[] s = new int[6];
            for (int i=0; i<sn.Length; i++)
            {
                s[i] = sn[i] + p[i];
            }
            
            for (int j=0; j<s.Length; j++)
            {
                port.Write(s[j].ToString());
                Pause();
            }
            
            BS_trackBar.Value  = p[0];
            SS_trackBar.Value  = p[1];
            ES_trackBar.Value  = p[2];
            WFS_trackBar.Value = p[3];
            WRS_trackBar.Value = p[4];
            GS_trackBar.Value  = p[5];

            BS_textBox.Text = p[0].ToString();
            SS_textBox.Text = p[1].ToString();
            ES_textBox.Text = p[2].ToString();
            WFS_textBox.Text = p[3].ToString();
            WRS_textBox.Text = p[4].ToString();
            GS_textBox.Text = p[5].ToString();
        }
        
        private void MoveToPlus(int [] plus) 
        {
            int[] pv = new int[] {BS_trackBar.Value, SS_trackBar.Value, ES_trackBar.Value, WFS_trackBar.Value, WRS_trackBar.Value, GS_trackBar.Value };
            
            int[] p = new int[6];
            for (int i = 0; i < sn.Length; i++)
            {
                p[i] = plus[i] + pv[i];
            }
            
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] > MaxDegrees)
                    p[i] = MaxDegrees;
            }

            MoveTo(p);
        }
        

        private void Home_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveTo(h);
        }

        private void Macro1_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveToPlus(new int[] { 10, 10, 10, 10, 10, 10 });
        }

        private void Macro2_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveTo(CeroArray);
        }

        private void Macro3_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveTo(CeroArray);
        }

        private void Macro4_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveTo(CeroArray);
        }

        private void Macro5_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveTo(CeroArray);
        }

        private void Macro6_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveTo(CeroArray);
        }

        private void Macro7_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveTo(CeroArray);
        }

        private void Macro8_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveTo(CeroArray);
        }

        private void Macro9_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveTo(CeroArray);
        }

        private void Macro10_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                MoveTo(CeroArray);
        }
    }
}
