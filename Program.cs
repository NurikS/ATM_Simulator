using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3ATM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public const int accountNo = 3;
        public static Account[] ac = new Account[accountNo];

        public static bool dataRace = true;

        public static void initializeAccounts()
        {
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }

        public static void changeDataRace()
        {
            if (dataRace == true)
            {
                dataRace = false;
            }
            else
            {
                dataRace = true;
            }
        }

        public static bool getDataRace()
        {
            return dataRace;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initializeAccounts();
            Application.Run(new MainMenu());
        }
    }
}
