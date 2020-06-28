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
    public partial class DeleteItem : Form
    {
        public event EventHandler<DeleteItemEventArgs> DeleteItemEvent;
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            EventHandler<DeleteItemEventArgs> handler = DeleteItemEvent;
            int pars = (int)deleteIdNum.Value;
            handler?.Invoke(this, new DeleteItemEventArgs(pars));
            this.Close();
        }
    }
}
