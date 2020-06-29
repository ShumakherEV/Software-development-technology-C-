using RunawayButton.EventsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunawayButton
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<Button> buttons;

        private int distance = 30;

        private void Runaway(object button)
        {
            ButtonAndMouse buttonAndMouse = (ButtonAndMouse)button;
            Button btn = buttonAndMouse.button;
            MouseEventArgs e = buttonAndMouse.mouse;

            int btnX = btn.Location.X + btn.Width / 2;
            int btnY = btn.Location.Y + btn.Height / 2;
            double len = Math.Sqrt((e.X - btnX) * (e.X - btnX) + (e.Y - btnY) * (e.Y - btnY));
            
            if (len < distance)
            {
                int newX = (int)((btnX - e.X) / len * distance + e.X) - btn.Width / 2;
                int newY = (int)((btnY - e.Y) / len * distance + e.Y) - btn.Height / 2;
                if (newX >= this.ClientSize.Width - btn.Width) newX = 0;
                if (newX < 0) newX = ClientSize.Width - btn.Width;
                if (newY >= this.ClientSize.Height - btn.Height) newY = 24;
                if (newY < 24) newY = ClientSize.Height - btn.Height;

                btn.Location = new Point(newX, newY);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                ButtonAndMouse buttonAndMouse = new ButtonAndMouse { button = buttons[i], mouse = e };
                Thread thread = new Thread(Runaway);
                thread.Start(buttonAndMouse);               
            }
        }

        private void myBtn_Click(object sender, EventArgs e)
        {
            string message = "Поздравляем! Вы смогли нажать кнопку!";
            DialogResult result = MessageBox.Show(message, "", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myBtn.Location = new Point(ClientSize.Width / 2 - myBtn.Width / 2,
                ClientSize.Height / 2 - myBtn.Height / 2);
            buttons = new List<Button> { myBtn };
        }

        private void addButtonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddButtons deleteItemForm = new AddButtons();
            deleteItemForm.AddButtonsEvent += new EventHandler<AddButtonsEventArgs>(this.OnAddButtonsEvent);
            deleteItemForm.Show();
        }

        public void OnAddButtonsEvent(object sender, AddButtonsEventArgs e)
        {
            Random random = new Random();

            if (e.Param < buttons.Count)
            {
                for (int i = buttons.Count - 1; i >= e.Param; i--)
                {
                    Controls.Remove(buttons[i]);
                    buttons.RemoveAt(i);
                }
            }
            for (int i = buttons.Count; i < e.Param; i++)
            {
                Button button = new Button
                {
                    Size = new Size { Width = 20, Height = 20 },
                    Text = i.ToString(),
                    Location = new Point(random.Next(100, ClientSize.Width - 100), random.Next(100, ClientSize.Height - 100))
                };
                
                this.Controls.Add(button);
                buttons.Add(button);
            }
        }
    }
}
