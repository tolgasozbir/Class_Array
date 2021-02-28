using System;

namespace D1_Sinif_Arrayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İnvoker PC\n");

            Pc laptop_1 = new Pc();
            laptop_1.ModelName = "İnvok-Wex";
            laptop_1.description = "8gb Ram , 512gb Ssd , 1080Ti Ekran Kartı";
            laptop_1.price = 4999.99;
            laptop_1.stockAmount = 18;

            Pc laptop_2 = new Pc();
            laptop_2.ModelName = "İnvok-Quass";
            laptop_2.description = "12gb Ram , 340gb Ssd , 1060 Ekran Kartı";
            laptop_2.price = 5499.99;
            laptop_2.stockAmount = 12;

            Pc laptop_3 = new Pc();
            laptop_3.ModelName = "İnvok-Exort";
            laptop_3.description = "16gb Ram , 512gb Ssd , 3060 Ekran Kartı";
            laptop_3.price = 7999.99;
            laptop_3.stockAmount = 5;

            Pc[] pcler = new Pc[] { laptop_1, laptop_2, laptop_3 };

            foreach (var item in pcler)
            {
                Console.WriteLine(item.ModelName    + "\n" +
                                item.description    + "\n" +
                                item.price          + "\n" +
                                item.stockAmount    + "\n");
            }

            Console.ReadKey();
        }
    }

    public class Pc
    {
        public string ModelName { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int stockAmount { get; set; }
    }
}
