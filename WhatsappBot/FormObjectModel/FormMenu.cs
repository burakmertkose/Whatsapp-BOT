using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsappBot.FormObjectModel
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            backButtonVisible();
            FormMain frm = (FormMain)Application.OpenForms["FormMain"];
            FormSendMessage form = new FormSendMessage();
            frm.OpenForm(form);
        }

        private void backButtonVisible()
        {
            FormMain frm = (FormMain)Application.OpenForms["FormMain"];
            frm.btnBack.Visible = true;
        }
    }
}
