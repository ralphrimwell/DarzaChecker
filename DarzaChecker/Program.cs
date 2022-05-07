using System;
using System.Threading.Tasks;
using System.Threading;

namespace DarzaChecker
{
    public class Program
    {


        
        static void InitChecker()
        {
            Console.Clear();
            UI.PrintTitle();
            Data.LoadCombos();
            //UI.QueryProxy();
    

            Parallel.ForEach<string>(Data.ComboList, combo =>
            {
                string email = combo.Split(new char[] { ':' })[0];
                string pass = combo.Split(new char[] { ':' })[1];
                Checker.SendRequest(email, pass);

            });

        }

        
        [STAThread]
        static void Main()
        {
            UI.PrintTitle();
            Console.WriteLine("");
            Console.WriteLine("DARZA'S DOMINION ACCOUNT CHECKER:");

            int option = UI.QueryOption(new string[] { "Start", "Exit"});
            switch(option)
            {
                case 0:
                    InitChecker();
                    break;

            }

            Console.Read();
        }
    }
}