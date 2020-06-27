using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Components
{
    public class Infantryman : Component
    {
        public Infantryman(string name) : base(name) { }

        public Infantryman() : base("безымянный") { }

        /// <summary>
        /// Print information about component
        /// </summary>
        /// <param name="tab"> The size of the indent from the beginning of the line </param>
        public override void Print(int tab)
        {
            string tabs = new String('\t', tab);
            Console.WriteLine($"{tabs}Пехотинец {name}");
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
