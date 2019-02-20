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
            string reason = reasonTextBox.Text;

            Server server = Server.GetInstance();
            server.Unregist(server.accessToken, server.userID, reason);

            Close();
            Program.Form = Program.Forms.Login;
        }

        private void UnregistForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* 로그아웃 */
            Server server = Server.GetInstance();
            server.Logout(server.accessToken);

            Close();
            Program.Form = Program.Forms.Login;
        }
    }
}
