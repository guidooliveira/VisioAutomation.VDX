using VisioAutomation.Power.Internal;
using SXL = System.Xml.Linq;

namespace VisioAutomation.Power.Elements
{
    public class Window
    {
        private static readonly IDGenerator idgen = new IDGenerator(0);

        private readonly int _id;
        public int? Width { get; set; }
        public int? Height { get; set; }

        protected Window()
        {
            this._id = Window.idgen.GetNextID();
        }

        public int ID
        {
            get { return this._id; }
        }

        public virtual void AddToElement(SXL.XElement parent)
        {
            throw new System.Exception();
        }
    }
}