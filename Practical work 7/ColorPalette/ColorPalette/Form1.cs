using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPalette
{
    public partial class Form1 : Form
    {
        private int red, green, blue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            red = green = blue = 125;
            box.BackColor = Color.FromArgb(red, green, blue);

            Clipboard.SetText("#" + red.ToString("X").PadLeft(2, '0')
                + green.ToString("X").PadLeft(2, '0')
                + blue.ToString("X").PadLeft(2, '0')); 

            colorTip.SetToolTip(box, Clipboard.GetText());
        }

        private void redTrack_ValueChanged(object sender, EventArgs e)
        {
            red = redTrack.Value;
            box.BackColor = Color.FromArgb(red, green, blue);

            Clipboard.SetText("#" + red.ToString("X").PadLeft(2, '0')
                + green.ToString("X").PadLeft(2, '0')
                + blue.ToString("X").PadLeft(2, '0')); 

            colorTip.SetToolTip(box, Clipboard.GetText());
        }

        private void greenTrack_ValueChanged(object sender, EventArgs e)
        {
            green = greenTrack.Value;
            box.BackColor = Color.FromArgb(red, green, blue);

            Clipboard.SetText("#" + red.ToString("X").PadLeft(2, '0')
                + green.ToString("X").PadLeft(2, '0')
                + blue.ToString("X").PadLeft(2, '0'));

            colorTip.SetToolTip(box, Clipboard.GetText());
        }

        private void blueTrack_ValueChanged(object sender, EventArgs e)
        {
            blue = blueTrack.Value;
            box.BackColor = Color.FromArgb(red, green, blue);

            Clipboard.SetText("#" + red.ToString("X").PadLeft(2, '0')
                + green.ToString("X").PadLeft(2, '0')
                + blue.ToString("X").PadLeft(2, '0')); 

            colorTip.SetToolTip(box, Clipboard.GetText());
        }
    }
}
