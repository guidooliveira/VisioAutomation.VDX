using VisioAutomation.Power.Internal;
using VisioAutomation.Power.Internal.Extensions;
using SXL = System.Xml.Linq;

namespace VisioAutomation.Power.Elements
{
    public class ColorEntry
    {
        public int RGB;

        private static void GetRGBBytes(int rgb, out byte r, out byte g, out byte b)
        {
            r = (byte) ((rgb & 0x00ff0000) >> 16);
            g = (byte) ((rgb & 0x0000ff00) >> 8);
            b = (byte) ((rgb & 0x000000ff) >> 0);
        }

        public void AddToElement(SXL.XElement parent, int ix)
        {
            var colorentry_el = XMLUtil.CreateVisioSchema2003Element("ColorEntry");
            colorentry_el.SetAttributeValueInt("IX", ix);

            byte rbyte;
            byte gbyte;
            byte bbyte;
            ColorEntry.GetRGBBytes(this.RGB, out rbyte, out gbyte, out bbyte);
            const string format_string = "#{0:x2}{1:x2}{2:x2}";
            string color_string = string.Format(System.Globalization.CultureInfo.InvariantCulture, format_string, rbyte, gbyte, bbyte);

            colorentry_el.SetAttributeValue("RGB", color_string);

            parent.Add(colorentry_el);
        }
    }
}