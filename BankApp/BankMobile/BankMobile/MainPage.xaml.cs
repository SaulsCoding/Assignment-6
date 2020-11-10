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

        private Bank _fnb;
        public MainPage()
        {
            InitializeComponent();
            Bank fnb = new Bank("First National Bank", 4324, "Kenilworth");
            Customer myNewCustomer = new Customer("7766445424", "10 me at home", "Bob", "The Builder");
            fnb.AddCustomer(myNewCustomer);

            /*var account = myNewCustomer.ApplyForBankAccount();
            account.DepositMoney(1500, DateTime.Now, "Stipend");*/




        }

        private void DepositButton_Clicked(object sender, EventArgs e)
        {
            decimal amount = Decimal.Parse(withdrawAmount.Text.ToString());
            string reason = depositAmount.Text.ToString();
           
        }

        private void DisplayHistoryButton_Clicked(object sender, EventArgs e)
        {

        }

        private void WithdrawAmounts_Clicked(object sender, EventArgs e)
        {
           // string hsistory = account.
        }
    }
}
