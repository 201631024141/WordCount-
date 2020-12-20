using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("请输入文件路径:");
            a = Console.ReadLine();
            StreamReader B = new StreamReader(a);
            string b = B.ReadLine();
            int result1 = 0;
            char[] c = b.ToCharArray();
            string[] d = b.Split(' ');
            for(int i=0;i<b.Length;i++)
            {
                if(c[i]>=65&&c[i]<=90||c[i]>=97&&c[i]<=122)
                {
                    result1++;
                }
            }
            Console.WriteLine("字母个数是："+result1);
            Console.WriteLine("单词个数是："+d.Length);
            B.Close();
        }
    }
}
