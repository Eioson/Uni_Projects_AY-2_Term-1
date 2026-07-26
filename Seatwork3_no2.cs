using System;
using System.Threading;

namespace ConsoleApp1
{
   class Program
    {   
        private double balance;
        void deposit(double input) // public modifier is omitted
        { balance += input; }
        void withdraw(double input) // re. Ln 9
        {  if (balance >= input)
            { balance -= input;}
            else
            { Console.WriteLine("Insufficient balance."); } }
        void displayBalance() // re. Ln 9
        { Console.Write($"\nThe current balance is \n> {balance}"); }
        static void Main(string[] wha) {
            Program ATM = new Program();
            Console.Write("Input Deposit Amount \n> ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            ATM.deposit(Amount);
            Console.Write("Deposit successful.");
            ATM.displayBalance();

            Console.Write("\nInput Withdraw Amount \n> ");
            double Withdrawal = Convert.ToDouble(Console.ReadLine());
            ATM.withdraw(Withdrawal);
            ATM.displayBalance(); } 
        } }