using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm küsib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja sisestab '2', siis kuvatakse eesnime esimest tähte
            //kui kasutja sisestab '3', siis kuvatakse kasutaja eesnime pikkus

            Console.WriteLine("sisesta oma eesnimi:");
            string userName = Console.ReadLine();//janek
            Console.WriteLine("Sisesta number 1 kuni 3");
            int userNumber = Convert.ToInt32(Console.ReadLine());//2
            GetUserNameData(userName, userNumber);
        }
        public static void GetUserNameData(string name, int number)
        {
            switch (number)
            {
                case 1:
                    //for (int i = name.Length - 1; i >= 0; i--)
                    // {
                    //     Console.Write(name[i]);
                    // }
                    GetUserNameData(name);

                    break;
                case 2:
                    Console.WriteLine($"Sinu eesnime esimene täht on {name[0]}");
                    break;
                case 3:
                    Console.WriteLine($"Sinu nimi on {name.Length} sümbolit pikk");
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void GetUserNameData(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
