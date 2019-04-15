using System;

namespace assign_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            double DAY = 99.99;
            double numOfDays;
            string codePrimerA = "YES";
            string codePrimerB = "NO";
            string exitPrimer = "EXIT";
            double totalRate;

        welcome(); 

        
        //Exit program Primer
        while(welcome() != exitPrimer){

            //Promo Code Entered
            while( welcome() == codePrimerA){
            System.Console.WriteLine("Please enter the number of days you are staying");
            numOfDays = Convert.ToInt32(Console.ReadLine());
            totalRate = computerRate(numOfDays);
            System.Console.WriteLine($"Your total bill will be ${totalRate}");
            reEnter();
            }
            //No Promo Code
            
            while(welcome() == codePrimerB){
            System.Console.WriteLine("Please enter the number of days you are staying");
            numOfDays = Convert.ToInt32(Console.ReadLine());
            totalRate = numOfDays * DAY;
            System.Console.WriteLine($"Your total bill will be ${totalRate}");
            
            }
        }
    }
            static double computerRate(double num){
                // ComputerRate DECLARATIONS
                string code;
                double DAYa = 169.00;
                double DAYc = 112.00;
                System.Console.WriteLine("Please enter your code.");
                code = Console.ReadLine();

            // Promo Code Decision 
            if(code == "A"){
                num = num * DAYa;
            }else if(code == "C"){
                num = num * DAYc;
            }

            //return value Double
            return num;

        }//end ComputerRate
        static string welcome(){
        // Defining primer
        string primer;
        System.Console.WriteLine("Welcome, this program will give you your room rate");
        System.Console.WriteLine("Do you have a Promo Code? Please enter 'YES' or 'NO'");
        primer = Console.ReadLine();

        return primer;
        }
        static string reEnter(){
            System.Console.WriteLine("Would you like to Continue?");

        }
    }
}
