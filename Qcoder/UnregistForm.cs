using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qcoder
{
    public partial class UnregistForm : Form
    {
        public UnregistForm()
        {
            InitializeComponent();
        }

        private void unregistButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("탈퇴 처리 후 계정 복구는 불가능합니다.\n정말로 탈퇴하시겠습니까?","",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string reason = reasonTextBox.Text;

                Server server = Server.GetInstance();
                server.Unregist(server.accessToken, server.userID, reason);

                Close();
                Program.Form = Program.Forms.Login;
            }
        }

        private void UnregistForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Form = Program.Forms.Main;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
