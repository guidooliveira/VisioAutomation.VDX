using VisioAutomation.Power.Internal;
using VisioAutomation.Power.ShapeSheet;
using SXL = System.Xml.Linq;

namespace VisioAutomation.Power.Sections
{
    public class TextXForm
    {
        public DistanceCell PinX = new DistanceCell();
        public DistanceCell PinY = new DistanceCell();
        public DistanceCell Width = new DistanceCell();
        public DistanceCell Height = new DistanceCell();
        public DistanceCell LocPinX = new DistanceCell();
        public DistanceCell LocPinY = new DistanceCell();
        public AngleCell Angle = new AngleCell();

        public void AddToElement(SXL.XElement parent)
        {
            var el = XMLUtil.CreateVisioSchema2003Element("TextXForm");
            el.Add(this.PinX.ToXml("TxtPinX"));
            el.Add(this.PinY.ToXml("TxtPinY"));
            el.Add(this.Width.ToXml("TxtWidth"));
            el.Add(this.Height.ToXml("TxtHeight"));
            el.Add(this.LocPinX.ToXml("TxtLocPinX"));
            el.Add(this.LocPinY.ToXml("TxtLocPinY"));
            el.Add(this.Angle.ToXml("TxtAngle"));
            parent.Add(el);
        }
    }
}