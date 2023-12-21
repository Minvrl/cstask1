//1.Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
using System;
using System.Xml;

using System;
using System.Diagnostics.CodeAnalysis;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("M ededini daxil edin:");
            string mNum = Console.ReadLine();
            int m = Convert.ToInt32(mNum);

            Console.WriteLine("N ededini daxil edin:");
            string nNum = Console.ReadLine();
            int n = Convert.ToInt32(nNum);

            Console.WriteLine("K ededini daxil edin:");
            string kNum = Console.ReadLine();
            int k = Convert.ToInt32(kNum);

            if (m > n && m > k)
            {
                Console.WriteLine($"En boyuk eded: {m}");
            }
            else if (n > m && n > k)
            {
                Console.WriteLine($"En boyuk eded: {n}");
            }
            else
            {
                Console.WriteLine($"En boyuk eded: {k}");
            }




            //2.Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram

            Console.WriteLine("Metn daxil edin:");
            string yazi = Console.ReadLine();

            bool varA = false;
            for (int i = 0; i < yazi.Length; i++)
            {
                char herfler = yazi[i];

                if (herfler == 'a')
                {
                    varA = true;
                    break;
                }
            }

            if (varA)
            {
                Console.WriteLine("Yazida a herfi var");
            }
            else
            {
                Console.WriteLine("Yazida a herfi yoxdur");
            }

            //3.Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
            Console.WriteLine("A herfinin sayinin tapilmasi ucun metn daxil edin:");
            string yazi2 = Console.ReadLine();

            int Count = 0;
            for (int i = 0; i < yazi2.Length; i++)
            {
                char herfler = yazi2[i];

                if (herfler == 'a')
                {
                    Count++;
                }
            }
            Console.WriteLine($"A herflerinin sayi: {Count}");

            //4.Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram. Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir
            Console.WriteLine("Musbet ve cut eded daxil edin:");

            int eded;
            do
            {
                string ededStr = Console.ReadLine();
                eded = Convert.ToInt32(ededStr);

                if (eded > 0 && eded % 2 == 0)
                {
                    int netice = eded * eded;
                    Console.WriteLine($" {eded}-kvadrati : {netice}");
                    break; 
                }
                else
                {
                    Console.WriteLine("Duzgun eded daxil edin (Musbet ve cut).");
                }
            }
            while (true);

            //5.Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram
            
            int[] nums = new int[5];
            int Sum = 0;

            Console.WriteLine("5 eded daxil edin:");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Eded {i + 1}: ");
                string input = Console.ReadLine();
                int inp = Convert.ToInt32(input);

                nums[i] = inp;
            }
            for (int i = 0; i< nums.Length; i++)
            {
                Sum=Sum+nums[i];
            }
                

            Console.WriteLine($"Daxil etdiyiniz ededlerin cemi: {Sum}");

            /*6.Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.
            Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat,
            "system"dirsə 200 saat,heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.*/

            Console.WriteLine("Derslerin saatini gormek ucun tehsil novunu daxil edin(programming,design,system):");
            string tehsil = Console.ReadLine();

            if (tehsil == "programming")
            {
                Console.WriteLine("Tehsil saatı - 400");
                
            }
            else if (tehsil == "design")
            {
                Console.WriteLine("Tehsil saatı - 250");
            }
            else if (tehsil == "system")
            {
                Console.WriteLine("Tehsil saatı - 200");
            }













        }

    }   
}
