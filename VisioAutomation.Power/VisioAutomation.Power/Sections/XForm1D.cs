using VisioAutomation.Power.Internal;
using VisioAutomation.Power.ShapeSheet;
using SXL = System.Xml.Linq;

namespace VisioAutomation.Power.Sections
{
    public class XForm1D
    {
        public DistanceCell BeginX = new DistanceCell();
        public DistanceCell BeginY = new DistanceCell();
        public DistanceCell EndX = new DistanceCell();
        public DistanceCell EndY = new DistanceCell();

        public void AddToElement(SXL.XElement parent)
        {
            var el = XMLUtil.CreateVisioSchema2003Element("XForm1D");
            el.Add(this.BeginX.ToXml("BeginX"));
            el.Add(this.BeginY.ToXml("BeginY"));
            el.Add(this.EndX.ToXml("EndX"));
            el.Add(this.EndY.ToXml("EndY"));

            parent.Add(el);
        }
    }
}