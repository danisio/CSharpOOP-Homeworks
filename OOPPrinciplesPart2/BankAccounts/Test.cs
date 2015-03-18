namespace BankAccounts
{
    using System;

    public class Test
    {
        public static void Main()
        {
            // add some test accounts to an instance of Bank
            Bank testBank = new Bank("MyBank");

            testBank.AddDepositAccount(new Individual("Ivan Ivanov"), 2);
            testBank.AddLoanAccount(new Company("My Company"), 10);
            testBank.AddMortgageAccount(new Company("NewCorp"), 5);

            // add some amounts to the balance and calculate interest
            testBank.Accounts[0].DepositMoney(2000);
            decimal firstAcc = testBank.Accounts[0].CalculateInterest(24);

            testBank.Accounts[1].DepositMoney(100000);
            decimal secondAcc = testBank.Accounts[1].CalculateInterest(12);

            testBank.Accounts[2].DepositMoney(20000);
            decimal thirdAcc = testBank.Accounts[2].CalculateInterest(18);

            // print all info about bank
            Console.WriteLine(testBank);
            Console.WriteLine("InterestRates of all accounts: {0:P}, {1:P}, {2:P}", firstAcc / 100, secondAcc / 100, thirdAcc / 100);
        }
    }
}
