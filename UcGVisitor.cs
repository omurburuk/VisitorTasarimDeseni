using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTasarımDeseni
{
    class _3GVisitor : IVisitor
    {
        public void Visit(Tablet tablet)
        {
            if(tablet is GalaxyTab)
                Console.WriteLine("Galaxy Tablet 3G açıldı");
            else if (tablet is IPad)
                Console.WriteLine("Ipad Tabletin wifi özelliği yok");
            else Console.WriteLine("Geçersiz Tablet");
        }
    }
}
