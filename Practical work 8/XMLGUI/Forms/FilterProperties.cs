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
    public partial class FilterProperties : Form
    {
        public event EventHandler<FilterChangeEventArgs> FilterChangeEvent;
        public FilterProperties()
        {
            InitializeComponent();
        }

        private void OnBtnApplyClick(object sender, EventArgs e)
        {
            EventHandler<FilterChangeEventArgs> handler = FilterChangeEvent;
            string pars = "";
            if (procTypeChb.Checked)
                pars += (string)procTypeCmb.SelectedItem + "§";
            else
                pars += "Null§";
            if (RAMSizeChb.Checked)
                pars += (string)RAMSizeCmb.SelectedItem + "§";
            else
                pars += "Null§";
            if (videoMemChb.Checked)
                pars += (string)videoMemCmb.SelectedItem + "§";
            else
                pars += "Null§";
            if (hardMemChb.Checked)
                pars += (string)hardMemCmb.SelectedItem;
            else
                pars += "Null";
            handler?.Invoke(this, new FilterChangeEventArgs(pars));
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FilterProperties_Load(object sender, EventArgs e)
        {
            procTypeCmb.SelectedIndex = 0;
            RAMSizeCmb.SelectedIndex = 0;
            videoMemCmb.SelectedIndex = 0;
            hardMemCmb.SelectedIndex = 0;
        }
    }
}
