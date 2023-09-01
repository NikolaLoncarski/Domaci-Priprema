using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*-------------------------Prvi Zadatak---------------------*//
            int[] niz = { 3, 7, 8, 1, 9 ,123,55,1233546};

            int maxNumber = MaxBroj(niz);
            Console.WriteLine(maxNumber);

            //*------------------------Drugi Zadatak------------------------*//
            int Broj =11111111;

            int rezultatBroj =  AddUp(Broj);
            Console.WriteLine(rezultatBroj);



            //*-------------------------------Zadatak 3 ------------------------*//
            string asd = "ana";
            string dsa = "banana";
            string dsaa = "radar";
            Console.WriteLine(Palindrom(asd));
            Console.WriteLine(Palindrom(dsa));
            Console.WriteLine(Palindrom(dsaa));


            Console.ReadKey();
            


        }
      



        //*-------------------------Prvi Zadatak---------------------*//
        public static int MaxBroj(int[] arr)
        {
            Array.Sort(arr);
            int biggest = arr[arr.Length - 1];
           
            return biggest;
        }

        //*------------------Drugi Zadatak--------------*//

        public static int AddUp(int broj)
        {
            return broj.ToString().Select(c => c - '0').Sum();
        }

        public static bool Palindrom (string Rec)
        {
            char[] CharArray = Rec.ToCharArray();
            Array.Reverse(CharArray);
          string ObrnutaRec = new string(CharArray);
            if (Rec == ObrnutaRec)
            {
                return true;
            } else return false;

        }
    }
       
    }
