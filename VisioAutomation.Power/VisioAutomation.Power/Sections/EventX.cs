using VisioAutomation.Power.Internal;
using VisioAutomation.Power.ShapeSheet;
using SXL = System.Xml.Linq;

namespace VisioAutomation.Power.Sections
{
    public class EventX
    {
        public DoubleCell EventMultiDrop = new DoubleCell();

        public void AddToElement(SXL.XElement parent)
        {
            var el = XMLUtil.CreateVisioSchema2006Element("Event");
            el.Add(this.EventMultiDrop.ToXml2006("EventMultiDrop"));
            parent.Add(el);
        }
    }
}