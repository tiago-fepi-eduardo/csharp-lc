using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lc.Csharp.Modulo2.Linq
{
    class ProgamLinq
    {
        static void Main()
        {
            List<string> objList = new List<string>();
            objList.Add("Vegeta");
            objList.Add("Cyber");
            objList.Add("Goku");
            objList.Add("Shiryu");

            //Select
            var result = objList.Select(s => s == "Goku");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            // Where return list
            var result2 = objList.Where(s => s == "Goku");
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }


            // Where return one
            var result3 = objList.Where(s => s == "Goku").FirstOrDefault();
            Console.WriteLine(result3);


            // FindAll
            List<int> numeros = new List<int> { -1, -3, 0, 1, 3, 2, 9, -4 };
            var resul4 = numeros.FindAll(n => n > 0);
            //var resul4 = numeros.Where(n => n > 0).ToList();

            foreach (var item in resul4)
            {
                Console.WriteLine(item);
            }



            // Filtrar classes compelxas
            List<Car> cars = new List<Car>
            {
                new Car{ Name = "Audi", Preco=52642 },
                new Car{ Name = "Mercedes", Preco=57127 },
                new Car{ Name = "Skoda", Preco=9000 },
                new Car{ Name = "Volvo", Preco=29000 },
                new Car{ Name = "Bentley", Preco=350000 },
                new Car{ Name = "Citroen", Preco=21000 },
                new Car{ Name = "Hummer", Preco=41400 },
                new Car{ Name = "Volkswagen", Preco=21600 }
            };
            //var result5 = cars.Where(c => c.Preco > 9000 && c.Preco < 50000).Select(c => new { c.Name, c.Preco });
            var result5 = cars.Select(c => new { c.Name});
            
            foreach (var car in result5)
            {
                Console.WriteLine($"{car.Name}");
                //Console.WriteLine($"{car.Name} {car.Preco}");
            }


        }
    }

    public class Car
    {
        public string Name { get; set; }
        public int Preco { get; set; }
    }
}
