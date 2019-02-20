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

        public enum Forms { Exit, Login, Welcome, Main, Type, Game, Unregist };
        public static Forms Form = Forms.Login;
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
                if(Form == Forms.Exit)
                {
                    break;
                }
                switch(Form)
                {
                    case Forms.Login:
                        Application.Run(new LoginForm());
                        break;
                    case Forms.Welcome:
                        Application.Run(new WelcomeForm(id, password));
                        break;
                    case Forms.Main:
                        Application.Run(new MainForm(nickname, jsonString));
                        break;
                    case Forms.Type:
                        Application.Run(new TypeForm());
                        break;
                    case Forms.Game:
                        Application.Run(new GameForm());
                        break;
                    case Forms.Unregist:
                        Application.Run(new UnregistForm());
                        break;
                }
            }
        }
    }
}
