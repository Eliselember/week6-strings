using System;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello world";

            //programm kuvab konsoolis sõna esimest tähte ja viimast tähte

            //kuvame esimest tähte
            Console.WriteLine(helloworld[0]);
            //kuvame viimast tähte
            Console.WriteLine(helloworld[helloworld.Length - 1]);
        }
    }
}
