using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onecondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("x입력: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine(x > 10 ? x < 20 ? "조건에 맞습니다." : "" : "");
        }
    }
}
