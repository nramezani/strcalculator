using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            String cn = "y";
            while (cn == "y" || cn == "Y")
            {
                int flag = 0;
                String d = "";
                string[] d1 = { };
                int d1L = 0;
                Console.WriteLine("                 ***       String Calculator     ***");

                String s = Console.ReadLine();
                if (s == "")
                {
                    Console.WriteLine(0);
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                if (s[0] == '/' & s[1] == '/')
                {

                    s = s.Remove(0, 2);
                    d1 = s.Split(',');
                    d1L = d1.Length;
                    d = "8";
                    s = "";

                }
                else
                {
                    d = ",";
                }

                String m = Console.ReadLine();

                s = s + m;
                if (d != ",")
                {
                    for (int j = 0; j < d1L; j++)
                    {

                        d = d1[j];
                        s = s.Replace(d, ",");
                    }

                }


                if (s != "")
                {
                    int sm = 0;
                    string[] str = s.Split(',');
                    int l = str.Length;
                    for (int i = 0; i < l; i = i + 1)
                    {
                        int a = int.Parse(str[i]);
                        if (a > 0)
                        {
                            if (a > 1000)
                                a = 0;
                            sm = a + sm;

                        }
                        else
                        {

                            Console.WriteLine(a);
                            flag = 1;
                        }

                    }
                    if (flag == 0)
                    {
                        Console.WriteLine("Sum is=" + sm);
                        Console.WriteLine("Do you want to continue? Y/N");
                        cn = Console.ReadLine();
                        if (cn == "n" || cn == "N")
                        {
                            System.Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Negatives not allowed");

                        Console.WriteLine("Do you want to continue? Y/N");
                        cn = Console.ReadLine();
                        if (cn == "N" || cn == "n")
                        {
                            System.Environment.Exit(0);
                        }

                    }


                }
                else
                {
                    Console.WriteLine("0");
                }
            }

            Console.ReadKey();
        }
    }
}
