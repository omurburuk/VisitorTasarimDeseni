using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTasarımDeseni
{
    class Program
    {
        static void Main(string[] args)
        {
            IPad a = new IPad("omur33", "61");
            a.Accept(new WifiVisitor());
            a.Accept(new _3GVisitor());
            GalaxyTab gtab = new GalaxyTab("Serna1", "61,5");
            gtab.Accept(new _3GVisitor());
            gtab.Accept(new WifiVisitor());
            Console.ReadLine();
        }

       
    }
}
