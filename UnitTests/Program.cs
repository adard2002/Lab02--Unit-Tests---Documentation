using System;

namespace UnitTests
{
    class Program
    {
        public static decimal Balance = 2034;

        public static void Main(string[] args)
        {

            UserInterface();
        } // ends Main Method

        public static void UserInterface()
        {
            Console.WriteLine("Hello and welcome to the ATM. Would you like to Deposit, Withdraw, or view your Balance?");



        } // ends UserInterface


        public static decimal ViewBalance()
        {
            return Balance;
        } // ends View Balance method



        public static decimal Withdraw()
        {
            return 0;
        } // ends Withdraw method



        public static decimal Deposit()
        {
            return 0;
        } // ends Deposit method



    }
}
