using System.Collections.Generic;
using VA=VisioAutomation;
using System.Collections;

namespace VisioAutomation.Power.Elements
{
    public class CustomProps : IEnumerable<CustomProp>
    {
        private readonly List<CustomProp> items;

        public CustomProps()
        {
            this.items = new List<CustomProp>();
        }

        public IEnumerator<CustomProp> GetEnumerator()
        {
            foreach (var i in this.items)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()     
        {                                           
            return this.GetEnumerator();
        }

        public int Count
        {
            get { return this.items.Count;  }
        }

        public void Add( CustomProp cp)
        {
            cp.ID = this.items.Count + 1;
            this.items.Add(cp);
        }
    }
}