using VisioAutomation.Power.Internal;
using VisioAutomation.Power.ShapeSheet;
using SXL = System.Xml.Linq;

namespace VisioAutomation.Power.Elements
{
    public class Layer : Node
    {
        public IntCell Color { get; set; }
        public IntCell Status { get; set; }
        public BoolCell Visible { get; set; }
        public BoolCell Print { get; set; }
        public BoolCell Active { get; set; }
        public BoolCell Lock { get; set; }
        public BoolCell Snap { get; set; }
        public BoolCell Glue { get; set; }

        public string Name
        {
            get { return this._Name.Result; }
            set { this._Name.Result = value; }
        }

        public string NameUniv
        {
            get { return this._NameUniv.Result; }
            set { this._NameUniv.Result = value; }
        }

        public TransparencyCell ColorTrans { get; set; }
        public int Index { get; private set; }
        private readonly StringCell _Name = new StringCell();
        private readonly StringCell _NameUniv = new StringCell();

        
        public Layer(string name, int index)
        {
            this.ColorTrans = new TransparencyCell();
            this.Glue = new BoolCell();
            this.Snap = new BoolCell();
            this.Lock = new BoolCell();
            this.Active = new BoolCell();
            this.Print = new BoolCell();
            this.Visible = new BoolCell();
            this.Status = new IntCell();
            this.Color = new IntCell();
            this.Name = name;
            this.NameUniv = name;
            this.Index = index;
        }

        internal void AddToElement(SXL.XElement parent)
        {
            var layer_el = XMLUtil.CreateVisioSchema2003Element("Layer");
            layer_el.SetAttributeValue("IX", this.Index);
            layer_el.Add(this._Name.ToXml("Name"));
            layer_el.Add(this._NameUniv.ToXml("NameUniv"));
            layer_el.Add(this.Color.ToXml("Color"));
            layer_el.Add(this.Status.ToXml("Status"));
            layer_el.Add(this.Visible.ToXml("Visible"));
            layer_el.Add(this.Print.ToXml("Print"));
            layer_el.Add(this.Active.ToXml("Active"));
            layer_el.Add(this.Lock.ToXml("Lock"));
            layer_el.Add(this.Snap.ToXml("Snap"));
            layer_el.Add(this.Glue.ToXml("Glue"));
            layer_el.Add(this.ColorTrans.ToXml("ColorTrans"));

            parent.Add(layer_el);
        }
    }
}