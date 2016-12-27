using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ackermann
{
    class Program
    {
        static void Main(string[] args) => new Program().Run();
        
        public void Run()
        {
            Console.WriteLine("N: ");
            Console.Write("> ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine("M: ");
            Console.Write("> ");
            ulong m = ulong.Parse(Console.ReadLine());

            ack(n, m);
            Run();
        }

        public ulong ack(ulong n, ulong m)
        {
            if (n == 0)
                return (m + 1);
            else if (m == 0)
                return ack(n - 1, 1);
            else
                return ack(n - 1, ack(n, m - 1));
        }
    }
}
