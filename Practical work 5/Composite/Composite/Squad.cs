using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// A container class. 
    /// The container contains operations to add / remove child components
    /// </summary>
    public class Squad: Component
    {
        private List<Component> components = new List<Component>();

        /// <summary>
        /// Standard class constructor
        /// </summary>
        public Squad(string name) : base(name)
        { }

        /// <summary>
        /// Add component
        /// </summary>
        public override void Add(Component component)
        {
            components.Add(component);
        }

        /// <summary>
        /// Remove component
        /// </summary>
        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        /// <summary>
        /// Print information about component
        /// </summary>
        /// <param name="tab"> The size of the indent from the beginning of the line </param>
        public override void Print(int tab)
        {
            string tabs = new String('\t', tab);
            Console.WriteLine($"{tabs}{name}, состав:");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print(tab + 1);
            }
            
        }
    }
}
