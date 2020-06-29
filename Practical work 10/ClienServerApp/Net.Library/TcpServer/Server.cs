using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SomeProject.Library.Server
{
    public class Server
    {
        TcpListener serverListener;
        int fileCounter = 0;

        public Server()
        {
            serverListener = new TcpListener(IPAddress.Loopback, 8080);
        }

        public bool TurnOffListener()
        {
            try
            {
                if (serverListener != null)
                    serverListener.Stop();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot turn off listener: " + e.Message);
                return false;
            }
        }

        public async Task TurnOnListener()
        {
            try
            {
                if (serverListener != null)
                    serverListener.Start();
                while (true)
                {
                    OperationResult result = await ReceiveMessageFromClient();
                    if (result.Result == Result.Fail)
                        Console.WriteLine("Unexpected error: " + result.Message);
                    else
                    {
                        Console.WriteLine("New message from client: " + result.Message);
                        if (result.Message.StartsWith("Sending file "))
                        {
                            result = await ReceiveFileFromClient(result.Message.Substring("Sending file ".Length));
                            if (result.Result == Result.Fail)
                                Console.WriteLine("Unexpected error: " + result.Message);
                            else
                            {
                                Console.WriteLine(result.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot turn on listener: " + e.Message);
            }
        }

        public async Task<OperationResult> ReceiveMessageFromClient()
        {
            try
            {
                Console.WriteLine("Waiting for connections...");
                StringBuilder recievedMessage = new StringBuilder();
                TcpClient client = serverListener.AcceptTcpClient();

                byte[] data = new byte[256];
                NetworkStream stream = client.GetStream();

                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    recievedMessage.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);
                stream.Close();
                client.Close();

                return new OperationResult(Result.OK, recievedMessage.ToString());
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }

        public OperationResult SendMessageToClient(string message)
        {
            try
            {
                TcpClient client = serverListener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();

                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
            return new OperationResult(Result.OK, "");
        }

        public async Task<OperationResult> ReceiveFileFromClient(string fileExt)
        {
            try
            {
                Console.WriteLine("Receiving file...");
                byte[] recievedFile = new byte[0];
                TcpClient client = serverListener.AcceptTcpClient();

                byte[] data = new byte[256];
                NetworkStream stream = client.GetStream();
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    recievedFile = recievedFile.Concat(data).ToArray();
                }
                while (stream.DataAvailable);
                
                string date = String.Format("{0:yyyy-MM-dd}", DateTime.Now); 
                
                Interlocked.Increment(ref fileCounter);

                System.IO.Directory.CreateDirectory(date);

                File.WriteAllBytes($"{date}/File{fileCounter}{fileExt}", recievedFile.ToArray());

                stream.Close();
                client.Close();

                return new OperationResult(Result.OK, "File received");
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }
    }
}