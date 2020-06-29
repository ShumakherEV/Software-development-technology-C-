using System;
using System.Windows.Forms;
using SomeProject.Library.Client;
using SomeProject.Library;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SomeProject.TcpClient
{
    public partial class ClientMainWindow : Form
    {
        public ClientMainWindow()
        {
            InitializeComponent();
        }

        private void OnMsgBtnClick(object sender, EventArgs e)
        {
            Client client = new Client();
            Result res = client.SendMessageToServer(textBox.Text).Result;
            if(res == Result.OK)
            {
                textBox.Text = "";
                labelRes.Text = "Message was sent succefully!";
            }
            else
            {
                labelRes.Text = "Cannot send the message to the server.";
            }
            timer.Interval = 2000;
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            labelRes.Text = "";
            timer.Stop();
        }

        private void sendFileBtn_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
            string fileExt = Path.GetExtension(filename);

            var fileText = System.IO.File.ReadAllBytes(filename);
            OperationResult operationResult = client.SendFileToServer(fileText, fileExt);
            
            Result res = operationResult.Result; 

            if (res == Result.OK)
            {
                textBox.Text = "";
                labelRes.Text = $"File was sent succefully!";
            }
            else
            {
                labelRes.Text = $"Cannot send the file to the server. {operationResult.Message}";
            }
            timer.Interval = 2000;
            timer.Start();
        }
    }
}
