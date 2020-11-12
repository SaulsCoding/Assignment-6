using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Banking;

namespace BankMobile
{
    public partial class MainPage : ContentPage
    {

        Bank fnb;
        Customer myNewCustomer;
        BankAccount account;
        public MainPage()
        {
            InitializeComponent();
            Bank fnb = new Bank("First National Bank", 4324, "Kenilworth");
            Customer myNewCustomer = new Customer("7766445424", "10 me at home", "Bob", "The Builder");
            fnb.AddCustomer(myNewCustomer);
            account = myNewCustomer.ApplyForBankAccount();

        }

        private void DepositButton_Clicked(object sender, EventArgs e)
        {
            decimal amount = Decimal.Parse(depositAmount.Text.ToString());
            string reason = depositReason.Text.ToString();
            account.DepositMoney(amount, DateTime.Now, reason);
        }


        private void WithdrawAmounts_Clicked(object sender, EventArgs e)
        {
            decimal amount = Decimal.Parse(withdrawAmount.Text.ToString());
            string reason = withdrawReason.Text.ToString();

            account.WithdrawMoney(amount, DateTime.Now, reason);
        }

        private void DisplayHistoryButton_Clicked(object sender, EventArgs e)
        {
            string history = account.GetTransactionHistory();
            DisplayAlert("Transaction History", history, "Done");
        }
    }
}
