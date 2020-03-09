using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int[] arr = new int[100];
        static int n;
        static void Khoitao()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhap day so, Enter de bat dau nhap!!");

            int i = 0;
            int j = 0;
            int err = 0;
            int lt = 0;
            bool bl = true;
            bool[] kt = { true, true, true };

            while ((lt != 3))
            {
                Console.Write("sai {0}\tarr[{1}]= ", err, i);
                bl = int.TryParse(Console.ReadLine(), out arr[i]);
                if (bl == true)
                {
                    i++;
                    kt[j % 3] = true;
                }
                else
                {
                    err++;
                    kt[j % 3] = false;
                    if ((kt[0] == kt[1]) && (kt[1] == kt[2]) && (kt[2] == kt[0]))
                    {
                        Console.WriteLine("nhap sai 3 lan lien tiep!!!!");
                        lt = 3;
                    }
                    if (err == 5)
                    {
                        Console.WriteLine("nhap sai 5 lan!!!!");
                        break;
                    }
                }
                j++;
            }

            n = i;
            Console.WriteLine();
        }
        static void try1()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Tong day so: " + sum);
            Console.WriteLine("Da nhap vao {0} so", n);
            int am = 0;
            int duong = am;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0) am++;
                else if (arr[i] > 0) duong++;
            }
            Console.WriteLine("\tTrong do co {0} so am, {1} so duong", am, duong);
        }
        static void Main(string[] args)
        {
            try
            {
                Khoitao();
                try1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
