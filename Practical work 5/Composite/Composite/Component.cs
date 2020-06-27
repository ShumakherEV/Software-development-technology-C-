using System;

namespace Composite
{
    /// <summary>
    /// General abstract class for military components
    /// </summary>
    public abstract class Component
    {
        /// <summary>
        /// Name of component
        /// </summary>
        protected string name;

        /// <summary>
        /// Standard class constructor
        /// </summary>
        public Component(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Add component
        /// </summary>
        public virtual void Add(Component component) { }

        /// <summary>
        /// Remove component
        /// </summary>
        public virtual void Remove(Component component) { }

        /// <summary>
        /// Print information about component
        /// </summary>
        /// <param name="tab"> The size of the indent from the beginning of the line </param>
        public virtual void Print(int tab)
        {
            string tabs = new String('\t', tab);
            Console.WriteLine($"{tabs}{name}");
        }
    }
}
