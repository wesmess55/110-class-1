using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.VariablesTest();

            List<int> nums = new List<int>(){1,2,3,4,5,6,7,8,9,123,567,123,78,16,723,10,135,2,46,78};
            p.HomeWork(nums);

        }
        public void HomeWork(List<int> numbers) {
            //Variables();
            System.Console.WriteLine("This is the solution");

            // 1 - print the sum of all numbers
            // 3 - print Only even numbers ( % )
            int sum = 0;
            // magic happens here to the set sum

            System.Console.WriteLine("Sum: " + sum);            
        }

        void VariablesTest()
        {
            string firstName= "Wes";
            int age = 31;
            float f = 13.231f;
            decimal total = 99.99m; 
            bool found = false;

            System.Console.WriteLine("Math Operations");
            System.Console.WriteLine(age -1);
            System.Console.WriteLine(age + 1);
            System.Console.WriteLine(age* 32);System.Console.WriteLine( age / 2);
            System.Console.WriteLine(age % 2);

              for (int i = 0; i < 10; i++)
            {
                if (i != 3 && i != 7) // if i not equal to 3 and i not equal to 7
                {
                    System.Console.WriteLine(i);
                }
            }


            // arrays
            string[] names = new string[5];
            names[0] ="Sergio";
            names[1] ="Letty";
            names[2] ="Mark";
            names[3] ="Kenneth";
            names[4] ="Ebbonnai";

            var lastNames =new List<string>();
            lastNames.Add("Ray");
            lastNames.Add("Smith");
            lastNames.Add("Posey");
            lastNames.Add("Inunza");
            lastNames.Add("Something");

            System.Console.WriteLine(lastNames.count);
            
            for (int i =0;i < lastNames.count; i++)
            {
                System.Console.WriteLine(lastNames[i]);

            }
            foreach (string last in lastNames){
                System.Console.WriteLine(last);
            }


        }
    }
}