using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            
            Console.Write("숫자를 입력해주세요 : ");
            var num = int.Parse(Console.ReadLine());
            min = num;
            max = num;
            for (int i = 0; i<4; i++)
            {
                Console.Write("숫자를 입력해주세요 : ");
                num = int.Parse(Console.ReadLine());
                if(num<min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("가장 큰 수 : " + max);
            Console.WriteLine("가장 작은 수 : " + min);
        }
    }
}
