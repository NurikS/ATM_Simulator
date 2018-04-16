using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace A3ATM
{
    public partial class MainMenu : Form
    {
        public bool DRState = false;
        public MainMenu()
        {
            InitializeComponent();
        }


        public void initATM()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ATMint());
        }

        private void EnterATM_Click(object sender, EventArgs e)
        {
            Thread ATM_t = new Thread(initATM);
            ATM_t.Start();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MainMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void DataRacelbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDataRace_Click_1(object sender, EventArgs e)
        {
            if (btnDR.BackColor == Color.Red) { btnDR.BackColor = Color.Green; DRState = true; }
            else btnDR.BackColor = Color.Red; DRState = false;
        }
    }
}
