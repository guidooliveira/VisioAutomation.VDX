using VisioAutomation.Power.Internal;
using VisioAutomation.Power.Internal.Extensions;
using VisioAutomation.Power.ShapeSheet;
using SXL = System.Xml.Linq;

namespace VisioAutomation.Power.Sections
{
    public class Ellipse : GeomRow
    {
        public DistanceCell X = new DistanceCell();
        public DistanceCell Y = new DistanceCell();
        public StringCell A = new StringCell();
        public StringCell B = new StringCell();
        public StringCell C = new StringCell();
        public StringCell D = new StringCell();

        public override void AddToElement(SXL.XElement parent, int index)
        {
            var el = XMLUtil.CreateVisioSchema2003Element("Ellipse");
            el.SetAttributeValueInt("IX", index);
            el.Add(this.X.ToXml("X"));
            el.Add(this.Y.ToXml("Y"));
            el.Add(this.A.ToXml("A"));
            el.Add(this.B.ToXml("B"));
            el.Add(this.C.ToXml("C"));
            el.Add(this.D.ToXml("D"));
            parent.Add(el);
        }
    }
}