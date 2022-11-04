using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsappBot.PageObjectModel;

namespace WhatsappBot.FormObjectModel
{
    public partial class FormSendMessage : Form
    {
        public FormSendMessage()
        {
            InitializeComponent();
            numberListFill();
        }

        private void numberListFill()
        {
            clbxNumbers.Items.Clear();

            foreach (var item in Whatsapp.contactUser)
            {
                clbxNumbers.Items.Add(item);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            Whatsapp whatsapp = new Whatsapp();
            int count = 1;
            int delay = 0;
            if (tbxMessageCount.Text != "")
            {
                count = int.Parse(tbxMessageCount.Text);
            }
            if (tbxDelay.Text != "")
            {
                delay = int.Parse(tbxDelay.Text);
            }


            if (clbxNumbers.CheckedItems.Count > 0)
            {
                List<string> get = new List<string>();
                foreach (var item in clbxNumbers.CheckedItems)
                {
                    get.Add(item.ToString());
                }

                try
                {

                    foreach (var item in get)
                    {
                        whatsapp.sendMessage(item, rtbxMessage.Text, count, delay);
                    }

                }
                catch (Exception)
                {
                }
            }
        }
    }
}
