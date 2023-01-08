namespace task_7___9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  #task7

            //Console.Write("Massivin uzunlugunu daxil edin");
            //int n = int.Parse(Console.ReadLine());
            //int[] mass = new int[n];
            //int count = 0;

            //for (int i = 0; i<mass.Length; i++)
            //{

            //    mass[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < mass.Length; i++)
            //{

            //   if (mass[i] % 7 == 1 || mass[i] % 7 == 2 || mass[i] % 7 == 5) ;
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine($"Massivin 7 bolende qaligi 1,2 ve ya 5 olan elementlerin sayi {count}");

            // #endtask7


            Console.Write("Massivin uzunlugunu daxil edin");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];

            int max = mass[0];
            

            for (int i = 1; i<mass.Length; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"mass[{i}]");
            }
            for (int i = 0; i<mass.Length; i++)
            {
                if (mass[i]> mass[max])
                {
                    max = i;

                }
            }

            Console.WriteLine($"massivin en boyuyu {max}");
                


















            







            Console.WriteLine("Hello, World!");
        }
    }
}