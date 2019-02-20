using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qcoder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public static int FormNumber = 1;
        public static string id;
        public static string password;
        public static string nickname;
        public static string jsonString;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                if(FormNumber == -1)
                {
                    break;
                }
                switch(FormNumber)
                {
                    case 1:
                        Application.Run(new LoginForm());
                        break;
                    case 2:
                        Application.Run(new WelcomeForm(id, password));
                        break;
                    case 3:
                        Application.Run(new MainForm(nickname, jsonString));
                        break;
                    case 4:
                        Application.Run(new TypeForm());
                        break;
                    case 5:
                        Application.Run(new GameForm());
                        break;
                }
            }
        }
    }
}
