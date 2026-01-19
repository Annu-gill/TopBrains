using System;

namespace BankTransactionProgram
{
    public class Program
    {
        static int GetFinalBalance(int initialBalance, int[] transactions)
        {
            int balance = initialBalance;

            foreach (int transaction in transactions)
            {
                if (transaction >= 0)
                {
                    // Deposit
                    balance += transaction;
                }
                else
                {
                    // Withdrawal (only if enough balance)
                    int withdrawalAmount = -transaction;
                    if (balance >= withdrawalAmount)
                    {
                        balance -= withdrawalAmount;
                    }
                    // else: ignore transaction
                }
            }

            return balance;
        }

        public static void Main()
        {
            // Read initial balance
            Console.Write("Initial Balance: ");
            int initialBalance = int.Parse(Console.ReadLine()!);

            // Read number of transactions
            Console.Write("Number of Transactions: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] transactions = new int[n];

            // Read transactions
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Transaction Amount: ");
                transactions[i] = int.Parse(Console.ReadLine()!);
            }

            int finalBalance = GetFinalBalance(initialBalance, transactions);

            Console.WriteLine("Final Balance: " + finalBalance);
        }
    }
}
