using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3ATM
{
    class Account
    {
            private int balance;
            private int pin;
            private int accountNumber;

            public Account(int bal, int p, int accNum)
            {
                this.balance = bal;
                this.pin = p;
                this.accountNumber = accNum;
            }

                    public bool getThreadSafe() 
        { 
            return threadSafe; 
        }

        /*
         *   This funciton allows us to decrement the balance of an account
         *   it perfomes a simple check to ensure the balance is greater tha
         *   the amount being debeted
         *   
         *   reurns:
         *   true if the transactions if possible
         *   false if there are insufficent funds in the account
         */
        public Boolean removeFromBalance(int x)
        {
            // Carry out transation as long as there is equal or more funds available
            if (this.balance >= x)
            {
                if (threadSafe)
                {
                    lock (thisLock)
                    {
                        int temporaryBalance = balance;
                        Thread.Sleep(1500);

                        temporaryBalance = temporaryBalance - x;
                        Thread.Sleep(1500);

                        balance = temporaryBalance;
                    }
                }
                else
                {
                    int temporaryBalance = balance;
                    System.Threading.Thread.Sleep(1500);

                    temporaryBalance = temporaryBalance - x;
                    System.Threading.Thread.Sleep(1500);

                    balance = temporaryBalance;
                }
                return true;
            }
            else
            {
                return false;
            }
        }    
        /**
            public Boolean removeFromBalance(int x)
            {
                int bal = balance;
                if (Program.getDataRace() == true)
                {
                    System.Threading.Thread.Sleep(2000);
                }

                if (balance >= x)
                {
                    balance = bal - x;
                    return true;
                }
                else
                {
                    return false;
                }

            }
        **/
            public Boolean checkPin(int enteredPin)
            {
                if (enteredPin == pin)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public int getBalance()
            {
                return balance;
            }

            public void setBalance(int newBalance)
            {
                balance = newBalance;
            }

            public int getAccountNum()
            {
                return accountNumber;
            }
        }
    }
