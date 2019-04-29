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
    public partial class SettingsForm : Form
    {
        private int[] FontSizes = { 9, 11, 13 };
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default["fontSize"] = int.Parse(fontSizeComboBox.SelectedItem.ToString());
                Properties.Settings.Default.Save();
                Close();
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Form = Program.Forms.Main;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < FontSizes.Length; i++)
                {
                    fontSizeComboBox.Items.Add(FontSizes[i]);
                    if (fontSizeComboBox.Items[i].ToString() == "" + MainForm.fontSize)
                    {
                        fontSizeComboBox.SelectedIndex = i;
                    }
                }
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }
    }
}
