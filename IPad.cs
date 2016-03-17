using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTasarımDeseni
{
    public class IPad:Tablet
    {

        string model;
        string brand;
        public IPad(string model, string brand):base(model,brand)
        {
         
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
