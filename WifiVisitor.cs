using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTasarımDeseni
{
    class WifiVisitor : IVisitor
    {
        public void Visit(Tablet tablet)
        {
            if (tablet is IPad)
                Console.WriteLine("Ipad wifi açıldı");
            else if (tablet is GalaxyTab)
                Console.WriteLine("Galaxy Tabletin wifi özelliği yok");
            else Console.WriteLine("Geçersiz Tablet");
        }
    }
}
