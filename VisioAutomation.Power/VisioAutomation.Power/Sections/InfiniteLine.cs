using VisioAutomation.Power.Internal.Extensions;
using VisioAutomation.Power.Internal;
using VisioAutomation.Power.ShapeSheet;
using SXL = System.Xml.Linq;

namespace VisioAutomation.Power.Sections
{
    public class InfiniteLine : GeomRow
    {
        public DistanceCell X = new DistanceCell();
        public DistanceCell Y = new DistanceCell();
        public StringCell A = new StringCell();
        public StringCell B = new StringCell();

        public override void AddToElement(SXL.XElement parent, int index)
        {
            var el = XMLUtil.CreateVisioSchema2003Element("InfiniteLine");
            el.SetAttributeValueInt("IX", index);
            el.Add(this.X.ToXml("X"));
            el.Add(this.Y.ToXml("Y"));
            el.Add(this.A.ToXml("A"));
            el.Add(this.B.ToXml("B"));
            parent.Add(el);
        }
    }
}