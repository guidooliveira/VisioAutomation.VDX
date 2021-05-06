using VisioAutomation.Power.Internal.Extensions;
using VisioAutomation.Power.Enums;
using VisioAutomation.Power.Internal;
using VisioAutomation.Power.ShapeSheet;
using SXL = System.Xml.Linq;

namespace VisioAutomation.Power.Sections
{
    public class ParagraphFormat
    {
        public DoubleCell IndFirst = new DoubleCell();
        public DoubleCell IndLeft = new DoubleCell();
        public DoubleCell IndRight = new DoubleCell();
        public DoubleCell SpLine = new DoubleCell();
        public DoubleCell SpBefore = new DoubleCell();
        public DoubleCell SpAfter = new DoubleCell();
        public EnumCell<ParaHorizontalAlignment> HorzAlign = new EnumCell<ParaHorizontalAlignment>(v => (int) v);
        public IntCell Bullet = new IntCell();
        public DoubleCell BulletStr = new DoubleCell();
        public IntCell BulletFont = new IntCell();
        public BoolCell LocalizeBulletFont = new BoolCell();
        public IntCell BulletFontSize = new IntCell();
        public DoubleCell TextPosAfterBullet = new DoubleCell();
        public IntCell Flags = new IntCell();

        public void AddToElement(SXL.XElement parent, int ix)
        {
            var el = XMLUtil.CreateVisioSchema2003Element("Para");

            el.SetAttributeValueInt("IX", ix);
            el.Add(this.IndFirst.ToXml("IndFirst"));
            el.Add(this.IndLeft.ToXml("IndLeft"));
            el.Add(this.IndRight.ToXml("IndRight"));

            el.Add(this.SpLine.ToXml("SpLine"));
            el.Add(this.SpBefore.ToXml("SpBefore"));
            el.Add(this.SpAfter.ToXml("SpAfter"));

            el.Add(this.HorzAlign.ToXml("HorzAlign"));
            el.Add(this.Bullet.ToXml("Bullet"));
            el.Add(this.BulletStr.ToXml("BulletStr"));
            el.Add(this.BulletFont.ToXml("BulletFont"));
            el.Add(this.LocalizeBulletFont.ToXml("LocalizeBulletFont"));
            el.Add(this.BulletFontSize.ToXml("BulletFontSize"));
            el.Add(this.TextPosAfterBullet.ToXml("TextPosAfterBullet"));
            el.Add(this.Flags.ToXml("Flags"));

            parent.Add(el);
        }
    }
}