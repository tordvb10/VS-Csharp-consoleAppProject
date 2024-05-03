namespace VS_Csharp_consoleAppProject
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int varint = 25;
            string varstring = "TVH";
            double vardouble = 25.33;

            string[] ArraySting = { "Hello", "World" };

            List<int> ListInt = new List<int>();
            ListInt.Add(varint);

            Console.WriteLine("Hello, World!");
            Console.WriteLine(varint + varstring + vardouble);

            Person newPerson = new Person();
            newPerson.Name = "TordVincentHeggland";

            Matte addering = new Matte();
            addering.Number1 = varint;
            addering.Number2 = 50;

            


            for (int i = 0; i < ArraySting.Length; i++)
            {
                Console.WriteLine(ArraySting[i]);
            }
            Console.WriteLine(ListInt.ToArray().ToString());
            Console.WriteLine(newPerson.Name);

            Console.WriteLine(addering.AddNumbers());

            string[] svar = newPerson.Name.Split("e");

            foreach (var item in svar)
            {
                Console.WriteLine(item);
            }

        }
        

    }
}
