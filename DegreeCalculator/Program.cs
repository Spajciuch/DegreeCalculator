using System;

namespace DegreeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w kalkulatorze, którego użyjesz prawdopodobnie tylko do 1 zadania.\n~Miłosz Lamański\n");
            
            while(true)
            {
                Console.Write("Miara kąta: ");
                var degree = Console.ReadLine();
                
                Console.Write("Minuty: ");
                var minutes = Console.ReadLine();
                // Reading user input ^^^^
                // Math: 
                if (minutes == "") minutes = "00";

                int degreeNumber = Int16.Parse(degree);

                int k = degreeNumber / 360;
                int rest = degreeNumber % 360;

                int minutesNumber = Int16.Parse(minutes);

                if(rest < 0 )
                {
                    k--;
                    rest = 360 - (-rest);
                }

                if (degreeNumber < 0)
                {
                    if (minutesNumber > 0)
                    {
                        rest--;
                        minutes = (60 - minutesNumber).ToString();
                    }
                }

                String result = "Odpowiedź: " + k.ToString() + " * 360° + " + rest.ToString() + "°" + minutes + "'";
                Console.WriteLine(result);
            }
        }
    }
}
