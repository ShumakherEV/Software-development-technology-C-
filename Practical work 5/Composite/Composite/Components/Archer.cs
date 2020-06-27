using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Components
{
    public class Archer : Component
    {
        public Archer(string name) : base(name) { }

        public Archer() : base("безымянный") { }

        /// <summary>
        /// Print information about component
        /// </summary>
        /// <param name="tab"> The size of the indent from the beginning of the line </param>
        public override void Print(int tab)
        {
            string tabs = new String('\t', tab);
            Console.WriteLine($"{tabs}Лучник {name}");
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
