using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoUDP
{
    class Program
    {
        private const int PORT = 22334;
        static void Main(string[] args)
        {
            Modtager m = new Modtager(PORT);
            m.Start();

            Console.ReadLine();
        }
    }
}
