using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number= 0;
            var count = 5;
            var price = 20.50f;
            char character =  'A';
            var firstName = "Oussama";
            var isWorking = false;
            Console.WriteLine(
                number
                ) ;
            Console.WriteLine(count);
            Console.WriteLine(character);
            Console.WriteLine(price);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            const float Pi = 3.14f;

            var osa = new Person();
            osa.firstName = "oussama";
            osa.introduce();

            var evens = new EvenNumbers();
            Console.WriteLine(evens.numbers[2]);


           
        }
    }
}
