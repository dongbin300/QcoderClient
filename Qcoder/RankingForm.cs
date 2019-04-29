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
    public partial class RankingForm : Form
    {
        private struct RankingObject
        {
            public int no;
            public string[] buttonString;
            public string[] serverString;
        };
        RankingObject typeMode;
        RankingObject criteria;
        RankingObject order;

        private enum Criteria { }

        public RankingForm()
        {
            InitializeComponent();
        }

        private void RankingForm_Load(object sender, EventArgs e)
        {
            typeMode = new RankingObject();
            typeMode.no = 0;
            typeMode.buttonString = new string[] { "단어", "짧은 글", "긴 글" };
            typeMode.serverString = new string[] { "word", "sentence", "article" };
            criteria = new RankingObject();
            criteria.no = 0;
            criteria.buttonString = new string[] { "점수", "TPM", "정확도", "완성", "진행" };
            criteria.serverString = new string[] { "score", "tpm", "accuracy", "right", "done" };
            order = new RankingObject();
            order.no = 0;
            order.buttonString = new string[] { "내림차순", "오름차순" };
            order.serverString = new string[] { "desc", "asc" };

            ListViewReload();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RankingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Form = Program.Forms.Main;
        }

        private void ListViewReload()
        {
            try
            {
                rankingListView.Items.Clear();
                Server server = Server.GetInstance();
                server.RankingJSON(server.LoadRecord(typeMode.serverString[typeMode.no], server.accessToken, criteria.serverString[criteria.no], order.serverString[order.no], 0));
                for (int i = 0; i < Math.Min(10, server.list.Count); i++)
                {
                    string[] str = new string[] { (i + 1) + "", server.rankUserID[i], server.rankScore[i] + "", server.rankTpm[i] + "", string.Format("{0:0.000}%", server.rankAccuracy[i]), server.rankInputRight[i] + "", server.rankInputDone[i] + "", server.rankTimeLimit[i] + "", server.rankRegDate[i] };
                    ListViewItem lvi = new ListViewItem(str);
                    rankingListView.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void typeModeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (++typeMode.no == typeMode.serverString.Length)
                    typeMode.no = 0;
                typeModeButton.Text = typeMode.buttonString[typeMode.no];

                ListViewReload();
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void criteriaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (++criteria.no == criteria.serverString.Length)
                    criteria.no = 0;
                criteriaButton.Text = criteria.buttonString[criteria.no];

                ListViewReload();
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (++order.no == order.serverString.Length)
                    order.no = 0;
                orderButton.Text = order.buttonString[order.no];

                ListViewReload();
            }
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
            }
        }
    }
}
