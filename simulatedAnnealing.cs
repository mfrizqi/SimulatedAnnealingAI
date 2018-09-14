using System;

namespace SimulatedAnnealing{
    class sa{
        static void Main(string[] args)
        {
            //pembuatan variable x1, x2,hasil rumus
            double x1,x2,hasil;
            const double phi = 3.14159;
            const double max = 10;
            const double min = -10;
            
            x1 = -2;
            x2 = -1;

            //Mengambil bilangan real random [-10,10]
            Random ran = new Random();
            for(int i =1;i<=10;i++){
                double dRan = ran.NextDouble() * (max - min) + min;
                Console.WriteLine(i+" random double value : " + dRan);
            }

            //penulisan rumus fungsi trigonometri
            hasil = -1 * Math.Abs( Math.Sin(x1) * Math.Cos(x2) * Math.Exp( Math.Abs( 1 - ( Math.Sqrt( Math.Pow(x1,2) + Math.Pow(x2,2)/phi )))));
            Console.WriteLine(hasil);
        }
    }
}