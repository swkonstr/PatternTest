using System;
using System.Collections.Generic;

namespace PatternTest
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");


            StarNameGenerator generator = new StarNameGenerator();

            Console.WriteLine("-- Generating 20 names with following format: V,C,V,C,FA");
            for (int i = 0; i < 40; i++)
            {
                //if (i % 8 == 0)
                //{
                //    Console.Write("\n\n");
                //}
                //Console.Write(string.Format("{0}, ", generator.GenerateName("V,C,V,C,FA")));
                Console.Write(string.Format("{0}, \n", generator.GenerateRandomName()));

            }


            Console.WriteLine("\n\n");

            List<Tile> tiles_arr = TilesArrInit.ReadFile();


            Planet plnt = new Planet(generator.GenerateRandomName(), 3, 3, tiles_arr);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Планета: " + plnt.name);
            Console.WriteLine("Координаты: " + plnt.x.ToString() + ", " + plnt.y.ToString());
            Console.WriteLine("Перечень районов:");
            foreach (Tile tile in plnt.tiles)
            {
                Console.WriteLine("Район: " + tile.Name);
                Console.WriteLine("Описание: " + tile.Description);
                Console.WriteLine("Плодоносность: " + tile.Fertility.ToString());
                Console.WriteLine("Продуктивность: " + tile.Production.ToString());
            }
            Console.WriteLine("\n\n");

            Random random = new Random();
            int dice = random.Next(1, tiles_arr.Count);
            Console.WriteLine("Tile №" + dice.ToString()+ " Name: " + tiles_arr[dice].Name);

            Console.ResetColor();
            Console.WriteLine("\n\n");

            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            Console.ReadLine();

        }
    }
}
