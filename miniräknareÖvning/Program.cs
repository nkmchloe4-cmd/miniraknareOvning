using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace miniräknareÖvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj räknesätt och 2 heltal som miniräknare kommer räkna ut");

            //Dessa är menyval användaren väljer bland
            Console.WriteLine("Miniräknare menyval");
            Console.WriteLine("[1] Addition");
            Console.WriteLine("[2] Subtraktion");
            Console.WriteLine("[3] Multiplikation");
            Console.WriteLine("[4] Division");

            Console.WriteLine("Skriv ditt val 1-4:");//Här väljer man mellan 1- 4 på menyn
            string userValue = Console.ReadLine();

            if (userValue != "1" && userValue != "2" && userValue != "3" && userValue != "4")
            {
                Console.WriteLine("Var god och välj mellan 1 - 4!");//Felmeddleandet vid inmatning av fel siffra
            }
            else
            {
                Console.WriteLine("Skriv ett tal:");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                //Dessa ska konvetrera inmatningar till siffror
                Console.WriteLine("Skriv andra talet:");
                int tal2 = Convert.ToInt32(Console.ReadLine());

                string message = "";

                if (userValue == "1")
                {
                    int summa = tal1 + tal2;
                    message = "Din summa är: " + summa;
                }
                else if (userValue == "2")
                {
                    int summa = tal1 - tal2;
                    message = "Din summa är: " + summa;
                }
                else if (userValue == "3")
                {
                    int summa = tal1 * tal2;
                    message = "Din summa är: " + summa;
                }
                else if (userValue == "4")
                {
                    if (tal2 != 0)
                    {
                        int summa = tal1 / tal2;
                        message = "Din summa är: " + summa;
                    }
                    else
                    {
                        message = "Det går inte dividera med 0"; //Vid inmatning av 0, detta kommer visas upp
                    }
                }
                               Console.WriteLine(message);//Förkorta kod med att skriva den här istället för flera gånger
            }
            Console.ReadLine();
        }
    }
}
