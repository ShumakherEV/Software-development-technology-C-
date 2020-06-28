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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int distance = 50;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int btnX = myBtn.Location.X + myBtn.Width / 2;
            int btnY = myBtn.Location.Y + myBtn.Height / 2;
            double len = Math.Sqrt((e.X - btnX) * (e.X - btnX) + (e.Y - btnY) * (e.Y - btnY));
            
            if (len < distance)
            {
                int newX = (int)((btnX - e.X) / len * distance + e.X) - myBtn.Width / 2;
                int newY = (int)((btnY - e.Y) / len * distance + e.Y) - myBtn.Height / 2;
                if (newX >= this.ClientSize.Width - myBtn.Width) newX = ClientSize.Width - myBtn.Width;
                if (newX < 0) newX = 0;
                if (newY >= this.ClientSize.Height - myBtn.Height) newY = ClientSize.Height - myBtn.Height;
                if (newY < 0) newY = 0;
                
                myBtn.Location = new Point(newX, newY);
            }
        }

        private void myBtn_Click(object sender, EventArgs e)
        {
            string message = "Поздравляем! Вы смогли нажать кнопку!";
            DialogResult result = MessageBox.Show(message,"", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myBtn.Location = new Point(ClientSize.Width/2 - myBtn.Width/2,
                ClientSize.Height / 2 - myBtn.Height / 2);
        }
    }
}
