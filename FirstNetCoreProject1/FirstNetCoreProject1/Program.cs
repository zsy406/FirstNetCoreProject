using System;

namespace FirstNetCoreProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dic = 56;
            dynamic a = Combin(dic, 10);
            Console.WriteLine(a);
            dic = "abcd";
            Console.WriteLine(dic);

            var str = "asdf.sss.abc|045";
            var strs = str.Split('|');
            Console.WriteLine(strs[1]);
            Console.ReadKey();

        }


        public static int Combin(dynamic a, int b)
        {
            return a.v + b;
        }
    }
}
