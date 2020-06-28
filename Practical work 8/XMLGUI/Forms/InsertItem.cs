using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLGUI.EventsLib;

namespace XMLGUI.Forms
{
    public partial class InsertItem : Form
    {
        public event EventHandler<InsertItemEventArgs> InsertItemEvent;
        public InsertItem()
        {
            InitializeComponent();
        }

        private void InsertItem_Load(object sender, EventArgs e)
        {

        }

        private void insertItemBtn_Click(object sender, EventArgs e)
        {
            EventHandler<InsertItemEventArgs> handler = InsertItemEvent;

            Computers.Computer pars = new Computers.Computer
            {
                Id = (int)numericUpDown1.Value,
                Model = textBox1.Text,
                ProcessorType = textBox1.Text,
                ProcessorSpeed = (uint)numericUpDown2.Value,
                RAMSize = (uint)numericUpDown3.Value,
                HardDriveCapacity = (uint)numericUpDown4.Value,
                VideoCardMemory = (uint)numericUpDown5.Value,
                Price = (uint)numericUpDown6.Value,
                CopiesAvailable = (uint)numericUpDown7.Value
            };
            handler?.Invoke(this, new InsertItemEventArgs(pars));
            this.Close();
        }
    }
}
