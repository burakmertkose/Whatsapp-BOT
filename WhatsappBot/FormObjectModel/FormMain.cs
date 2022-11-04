using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using WhatsappBot.FormObjectModel;
using WhatsappBot.Utilities;
using WhatsappBot.PageObjectModel;

namespace WhatsappBot
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            ChromeDriverUpdate();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            string myNumber = whatsapp.getMyNumber();
            lblBar.Text = "   WHATSAPP BOT | " + myNumber;

            
            lblContactGetInfo.Text = "please wait... scanning the whatsapp...";
            Thread.Sleep(2000);
            whatsapp.getContactList();
            lblContactGetInfo.Text = Whatsapp.contactUser.Count+" user contact ready (click to refresh)";

            FormMenu formMenu = new FormMenu();
            OpenForm(formMenu);

        }
        Whatsapp whatsapp = new Whatsapp();


        private void ChromeDriverUpdate()
        {
            //new DriverManager().SetUpDriver(new ChromeConfig(), "105.0.5195.52");
            new DriverManager().SetUpDriver(VersionResolveStrategy.MatchingBrowser, Path.Combine(Directory.GetCurrentDirectory(), "chromedriver.exe"), "chromedriver.exe");
        }


        public void OpenForm(Form openForm)
        {
            panel.Controls.Clear();
            openForm.TopLevel = false;
            openForm.Dock = DockStyle.Fill;
            panel.Controls.Add(openForm);
            openForm.BringToFront();
            openForm.Show();
        }


        int x, y, move = 0;
        private void lblBar_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        private void lblBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            OpenForm(formMenu);
            btnBack.Visible = false;
        }

        // Refrest scannig to whatsapp
        private void lblContactGetInfo_Click(object sender, EventArgs e)
        {
            FormMenu mainMenu = new FormMenu();
            OpenForm(mainMenu);
            whatsapp.getContactList();
            lblContactGetInfo.Text = Whatsapp.contactUser.Count + " user contact ready (click to refresh)";
        }

        private void lblBar_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            Whatsapp whatsapp = new Whatsapp();
            whatsapp.quitWhatsapp();
            Driver.quitDriver();
            Environment.Exit(0);
        }
    }
}
