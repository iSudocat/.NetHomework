using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 *编写程序输出用户指定数据的所有素数因子。(分解质因数)
 */

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(process(num));
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("请正确输入。");
            }
        }

        static private string process(int num)
        {
            string re = "";
            for (int i = 2; i < num; i++)
            {
                while (num != i)
                {
                    if (num % i == 0)
                    {
                        re = re + i + " ";
                        num /= i;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            re = re + num;
            return re;
        }

    }


}
