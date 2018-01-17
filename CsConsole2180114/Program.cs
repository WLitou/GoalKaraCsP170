using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsConsole2180114
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, ans;
            float amari;
            string owari;
            while (true)
            {
                Console.WriteLine("終わる場合はeを入力、続ける場合はe以外を押す");
                owari = Console.ReadLine();
                if (owari == "e")
                {
                    break;
                }
                else
                {
                    try
                    {
                        Console.WriteLine("割られる数＞");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("次は割る数");
                        n2 = int.Parse(Console.ReadLine());
                        ans = n1 / n2;
                        amari = n1 % n2;
                        Console.WriteLine("答えは{0}余りは{1}", ans, amari);
                    }
                    catch (FormatException f)
                    {
                        Console.WriteLine(f);
                    }
                    catch (DivideByZeroException z)
                    {
                        Console.WriteLine(z);
                    }
                }

            }
        }
    }
}
