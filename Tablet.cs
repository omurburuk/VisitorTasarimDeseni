using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTasarımDeseni
{
   public abstract class Tablet
    {
        string Model;
        string Brand;

        public Tablet(string Model,string Brand)
        {
            this.Model = Model;
            this.Brand = Brand;
        }

        public abstract void Accept(IVisitor visitor);
        
    }
}
