namespace VisitorTasarımDeseni
{
    public class GalaxyTab:Tablet
    {
        string model;
        string brand;
        public GalaxyTab(string model, string brand):base(model,brand)
        {

        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}