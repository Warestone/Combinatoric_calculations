using System;
using System.Text;

namespace Combinatorics
{
    class Program
    {
        static string Input;
        static int N, K;
        static long Var1, Var2, Var3, Result;
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            M1:
            Console.Clear();
            Console.WriteLine("\t\tDescription: this program was created to help with combinatorics calculations.\n\t\tCreated by John Warestone.\n\nPlease, choose a calculation formula:\n\n");
            Console.WriteLine("\t       k    n!\n\t(1)   A = ------\n\t       n  (n-k)!\n");
            Console.WriteLine("\t       k      n!\n\t(2)   C = --------\n\t       n  k!(n-k)!\n");
            Console.WriteLine("             ___\n\t       k   k\n\t(3)   A = N\n\t       n\n");
            Console.WriteLine("             ___\n\t       k   k\n\t(4)   C = C\n\t       n   n+k-1\n");
            Console.WriteLine("\t(5)   P = n!\n\t       n\n");
            string Menu = Console.ReadLine();
            switch (Menu)
            {
                case "0":
                    return;
                case "1":
                    Task1();                    
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                case "5":
                    Task5();
                    break;
                default:
                    Console.WriteLine("\n\t\t****INCORRECT INPUT****\n");
                    break;
            }
            goto M1;
        }
        private static void Task1()
        {                     
            M1:
            Console.WriteLine("\n***Without return, accommodation***\n\tn - amount of set\n\tk - amount of subset size\n\n\t k    n!\n\tA = ------\n\t n  (n-k)!\n\nEnter the n and k separating a space, k must be <= n! and n must be >0 or just zero for exit to Main\n");
            Input = Console.ReadLine();
            if (Input == "0")
            {
                return;
            }
            try
            {
                N = Convert.ToInt32(Input.Substring(0, 1));
                K = Convert.ToInt32(Input.Substring(1, 2));
            }
            catch (Exception) { Console.WriteLine("\n\t\t****INCORRECT INPUT****\n"); goto M1; }
            if (K > N)
            {
                Console.WriteLine("\n\t\t****INCORRECT INPUT. k must be <= n!****\n");
                goto M1;
            }
            Var1 = 1;
            for (int i = 1; i <= N; i++)
            {
                Var1 *= i;
            }
            Var2 = 1;
            for (int i = 1; i <= N - K; i++)
            {
                Var2 *= i;
            }
            Result = Var1 / Var2;
            Console.WriteLine("\n\n***Result of calulation = " + Result + "***\nPress 'Enter' to continue ...\n");
            Console.ReadKey();         
        }
        private static void Task2()
        {
            M1:
            Console.WriteLine("\n***Without return, combination***\n\tn - amount of set\n\tk - amount of subset size\n\n\t k      n!\n\tC = --------\n\t n  k!(n-k)!\n\nEnter the n and k separating a space, k must be <= n! and n must be >0 or just zero for exit to Main\n");
            Input = Console.ReadLine();
            if (Input == "0")
            {
                return;
            }
            try
            {
                N = Convert.ToInt32(Input.Substring(0, 1));
                K = Convert.ToInt32(Input.Substring(1, 2));
            }
            catch (Exception) { Console.WriteLine("\n\t\t****INCORRECT INPUT****\n"); goto M1; }
            if (K > N)
            {
                Console.WriteLine("\n\t\t****INCORRECT INPUT. k must be <= n!****\n");
                goto M1;
            }
            Var1 = 1;
            for (int i = 1; i <= N; i++)
            {
                Var1 *= i;
            }
            Var2 = 1;
            for (int i = 1; i <= K; i++)
            {
                Var2 *= i;
            }
            Var3 = 1;
            for (int i = 1; i <= N - K; i++)
            {
                Var3 *= i;
            }
            Result = Var1 / (Var2 * Var3);
            Console.WriteLine("\n\n***Result of calulation = " + Result + "***\nPress 'Enter' to continue ...\n");
            Console.ReadKey();
        }
        private static void Task3() //
        {
            M1:
            Console.WriteLine("\n***With return, accommodation***\n\tn - amount of set\n\tk - amount of subset size\n\n       ___\n\t k   k\n\tA = N\n\t n\n\nEnter the n and k separating a space, k - any value >=0 and n >=0 or just zero for exit to Main\n");
            Input = Console.ReadLine();
            if (Input == "0")
            {
                return;
            }
            try
            {
                N = Convert.ToInt32(Input.Substring(0, 1));
                K = Convert.ToInt32(Input.Substring(1, 2));
            }
            catch (Exception) { Console.WriteLine("\n\t\t****INCORRECT INPUT****\n"); goto M1; }
            try
            {
                Result = Convert.ToInt64(Math.Pow(N, K));
            }
            catch (Exception){ Console.WriteLine("\n\n***Too long value!***\nPress 'Enter' to continue ...\n"); Console.ReadKey();return; }
            Console.WriteLine("\n\n***Result of calulation = " + Result + "***\nPress 'Enter' to continue ...\n");
            Console.ReadKey();         
        }
        private static void Task4()
        {
            M1:
            Console.WriteLine("\n***With return, combination***\n\tn - amount of set\n\tk - amount of subset size\n\n       ___\n\t k   k\n\tC = C\n\t n   n+k-1\n\nEnter the n and k separating a space, k - any value >=0 and n >=0 or just zero for exit to Main\n");
            Input = Console.ReadLine();
            try
            {
                N = Convert.ToInt32(Input.Substring(0, 1));
                K = Convert.ToInt32(Input.Substring(1, 2));
            }
            catch (Exception) { Console.WriteLine("\n\t\t****INCORRECT INPUT****\n"); goto M1; }
            if (K > N)
            {
                Console.WriteLine("\n\t\t****INCORRECT INPUT. k must be <= n!****\n");
                goto M1;
            }
            Var1 = 1;
            for (int i = 1; i <= N; i++)
            {
                Var1 *= i;
            }
            Var2 = 1;
            for (int i = 1; i <= K; i++)
            {
                Var2 *= i;
            }
            Var3 = 1;
            for (int i = 1; i <= N - K; i++)
            {
                Var3 *= i;
            }
            Result = Var1 / (Var2 * Var3);
            Console.WriteLine("\n\n***Result of calulation = " + Result + "***\nPress 'Enter' to continue ...\n");
            Console.ReadKey();
        }

        private static void Task5()
        {
            M1:
            Console.WriteLine("\n***Permutations***\n\tn - amount of set\n\n\tP = n!\n\t n\n\nEnter the n value, n > 0 or just zero for exit to Main\n");
            Input = Console.ReadLine();
            if (Input == "0") { return; }
            try
            {
                N = Convert.ToInt32(Input.Substring(0, 1));                
            }
            catch (Exception) { Console.WriteLine("\n\t\t****INCORRECT INPUT****\n"); goto M1; }
            Result = 1;
            for (int i = 1; i <= N; i++)
            {
                Result *= i;
            }
            Console.WriteLine("\n\n***Result of calulation = " + Result + "***\nPress 'Enter' to continue ...\n");
            Console.ReadKey();
        }        
    }
}
