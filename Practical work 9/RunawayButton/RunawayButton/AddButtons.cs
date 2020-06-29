using RunawayButton.EventsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunawayButton
{
    public partial class AddButtons : Form
    {
        public event EventHandler<AddButtonsEventArgs> AddButtonsEvent;
        public AddButtons()
        {
            InitializeComponent();
        }

        private void addButtonsBtn_Click(object sender, EventArgs e)
        {
            EventHandler<AddButtonsEventArgs> handler = AddButtonsEvent;
            int pars = (int)numberButtonsBtn.Value;
            handler?.Invoke(this, new AddButtonsEventArgs(pars));
            this.Close();
        }
    }
}
