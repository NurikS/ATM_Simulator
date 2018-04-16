using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3ATM
{
    public partial class ATMint : Form
    {
        private String txtFieldState = "account";
        private int accountIDTracker;
        private bool accountFound = false;
        private String ATMState = "menu";
        private String cash;
        public ATMint()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
           txtInput.Text = txtInput.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int input = 0;

            if (txtInput.Text != "")
            {
                input = Convert.ToInt32(txtInput.Text);
            }

            if (txtFieldState == "account")
                for (int i = 0; i < Program.accountNo; i++)
                {
                    if (Program.ac[i].getAccountNum()==input)
                    {
                        accountIDTracker = i;
                        lblSignIn.Text = "PIN";
                        txtInput.Text = "";
                        txtFieldState = "PIN";
                        accountFound = true;
                    }
                    else if(accountFound == false)
                    {
                        lblSignIn.Text = "Please enter valid account";
                        txtInput.Text = "";
                    }
                }
            else if (txtFieldState == "PIN")
            {
                if (Program.ac[accountIDTracker].checkPin(input))
                {
                    lblSignIn.Visible = false;
                    txtInput.Visible = false;
                    lblBalance.Visible = true;
                    lblCash.Visible = true;
                    lblExit.Visible = true;
                }
                else
                {
                    lblSignIn.Text = "Invalid PIN";
                    txtInput.Text = "";
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ATMState == "menu")
            {
                String balance;
                txtInput.Visible = false;
                lblBalance.Visible = false;
                lblCash.Visible = false;
                lblExit.Visible = true;
                lblSignIn.Visible = true;
                balance = Convert.ToString(Program.ac[accountIDTracker].getBalance());
                lblSignIn.Text = "Balance is: " + balance + "£";
            }
            else if (ATMState == "cash")
            {
                if (Program.ac[accountIDTracker].getBalance() > 5)
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = false;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "You've withdrawn £5";
                    Program.ac[accountIDTracker].removeFromBalance(5);
                }
                else
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = true;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "Insufficient Funds";
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ATMState == "menu")
            {
                Application.Exit();
            }
            else if (ATMState == "cash")
            {
                if (Program.ac[accountIDTracker].getBalance() > 100)
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = false;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "You've withdrawn £100";
                    Program.ac[accountIDTracker].removeFromBalance(100);
                }
                else
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = true;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "Insufficient Funds";
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ATMState == "menu")
            {
                txtInput.Visible = false;
                lblBalance.Visible = true;
                lblCash.Visible = true;
                lblExit.Visible = true;
                lblSignIn.Visible = false;
                lblCash10.Visible = true;
                lblCash50.Visible = true;
                lblCash250.Visible = true;
                lblBalance.Text = "5£";
                lblCash.Text = "20£";
                lblExit.Text = "100£";
                ATMState = "cash";
            }
            else if (ATMState == "cash")
            {
                if (Program.ac[accountIDTracker].getBalance() > 20)
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = false;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "You've withdrawn £20";
                    Program.ac[accountIDTracker].removeFromBalance(20);
                }
                else
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = true;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "Insufficient Funds";
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ATMState == "cash")
            {
                if (Program.ac[accountIDTracker].getBalance() > 10)
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = false;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "You've withdrawn £10";
                    Program.ac[accountIDTracker].removeFromBalance(10);
                }
                else
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = true;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "Insufficient Funds";
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ATMState == "cash")
            {
                if (Program.ac[accountIDTracker].getBalance() > 50)
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = false;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "You've withdrawn £50";
                    Program.ac[accountIDTracker].removeFromBalance(50);
                }
                else
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = true;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "Insufficient Funds";
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ATMState == "cash")
            {
                if (Program.ac[accountIDTracker].getBalance() > 250)
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = false;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "You've withdrawn £250";
                    Program.ac[accountIDTracker].removeFromBalance(250);
                }
                else
                {
                    lblBalance.Visible = false;
                    lblCash.Visible = false;
                    lblExit.Visible = true;
                    lblCash10.Visible = false;
                    lblCash50.Visible = false;
                    lblCash250.Visible = false;
                    lblSignIn.Visible = true;
                    lblSignIn.Text = "Insufficient Funds";
                }
            }
        }
    }
}
