using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsappBot.Utilities;
using WhatsappBot.PageObjectModel;
using System.Threading;

namespace WhatsappBot.FormObjectModel
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(getQR);
            th.IsBackground = true;
            th.Start();
        }
        LoginWhatsapp loginWhatsapp = new LoginWhatsapp();
        private void getQR()
        {
            
            loginWhatsapp.navigateWp();
            while (true)
            {
                pictureBox1.Image = loginWhatsapp.getScreenShotQR();
                if (loginWhatsapp.loginVerify())
                    break;
            }
            // LOGİN SUCCESFULL
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loginWhatsapp.navigateWpRefresh();
        }
        private void lblQuit_Click(object sender, EventArgs e)
        {
            Driver.quitDriver();
            Environment.Exit(0);
        }

        int x, y,move = 0;
        private void lblBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void lblBar_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
        }

        private void lblBar_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
    }
}
