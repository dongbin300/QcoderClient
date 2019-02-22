using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

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
        public static string language;
        public static string jsonString;

        private static System.Timers.Timer reissueTokenTimer;

        [STAThread]
        static void Main()
        {
            reissueTokenTimer = new System.Timers.Timer();
            reissueTokenTimer.Elapsed += new ElapsedEventHandler(reissueTokenTimer_Elapsed);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                if (Form == Forms.Exit)
                {
                    Server server = Server.GetInstance();
                    if (server.accessToken != null)
                    {
                        server.Logout(server.accessToken);
                    }
                    break;
                }
                switch (Form)
                {
                    case Forms.Login:
                        Application.Run(new LoginForm());
                        break;
                    case Forms.Welcome:
                        Application.Run(new WelcomeForm(id, password));
                        break;
                    case Forms.Main:
                        if (!reissueTokenTimer.Enabled)
                        {
                            Server server = Server.GetInstance();
                            DateTime expDate = DateTime.ParseExact(server.expDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            DateTime updDate = DateTime.ParseExact(server.updDate, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            TimeSpan diff = expDate - updDate - new TimeSpan(0, 5, 0);
                            reissueTokenTimer.Interval = (diff.Days * 86400 + diff.Hours * 3600 + diff.Minutes * 60 + diff.Seconds) * 1000;
                            reissueTokenTimer.Start();
                        }
                        Application.Run(new MainForm(nickname));
                        break;
                    case Forms.Type:
                        Application.Run(new TypeForm(language));
                        break;
                    case Forms.Game:
                        Application.Run(new GameForm(language));
                        break;
                    case Forms.Unregist:
                        Application.Run(new UnregistForm());
                        break;
                }
            }
        }

        static void reissueTokenTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Server server = Server.GetInstance();
            server.ReissueToken(server.accessToken, server.refreshToken);
        }
    }
}
