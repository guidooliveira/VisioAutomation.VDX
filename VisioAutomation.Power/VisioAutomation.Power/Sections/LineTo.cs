using VisioAutomation.Power.Internal.Extensions;
using VisioAutomation.Power.Internal;
using VisioAutomation.Power.ShapeSheet;
using SXL = System.Xml.Linq;

namespace VisioAutomation.Power.Sections
{
    public class LineTo : GeomRow
    {
        public DistanceCell X = new DistanceCell();
        public DistanceCell Y = new DistanceCell();

        public override void AddToElement(SXL.XElement parent, int index)
        {
            var el = XMLUtil.CreateVisioSchema2003Element("LineTo");
            el.SetAttributeValueInt("IX", index);
            el.Add(this.X.ToXml("X"));
            el.Add(this.Y.ToXml("Y"));
            parent.Add(el);
        }

        public LineTo(double x, double y)
        {
            this.X.Result = x;
            this.Y.Result = y;
        }
    }
}