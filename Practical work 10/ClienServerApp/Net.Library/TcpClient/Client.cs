using System;
using System.Text;
using System.Net.Sockets;


namespace SomeProject.Library.Client
{
    public class Client
    {
        public TcpClient tcpClient;

        public OperationResult ReceiveMessageFromServer()
        {
            try
            {
                tcpClient = new TcpClient("127.0.0.1", 8080);
                StringBuilder recievedMessage = new StringBuilder();
                byte[] data = new byte[256];
                NetworkStream stream = tcpClient.GetStream();

                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    recievedMessage.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);
                stream.Close();
                tcpClient.Close();

                return new OperationResult(Result.OK, recievedMessage.ToString());
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.ToString());
            }
        }

        public OperationResult SendMessageToServer(string message)
        {
            try
            {
                tcpClient = new TcpClient("127.0.0.1", 8080);
                NetworkStream stream = tcpClient.GetStream();
                byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                stream.Close();
                tcpClient.Close();
                return new OperationResult(Result.OK, "") ;
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }

        public OperationResult SendFileToServer (byte[] message, string fileExt)
        {
            try
            {
                tcpClient = new TcpClient("127.0.0.1", 8080);               
                NetworkStream stream = tcpClient.GetStream();
                byte[] data = System.Text.Encoding.UTF8.GetBytes($"Sending file {fileExt}");
                stream.Write(data, 0, data.Length);
                stream.Close();
                tcpClient.Close();

                tcpClient = new TcpClient("127.0.0.1", 8080);
                stream = tcpClient.GetStream();
                data = message;
                int offset = 0;
                
                while (offset + 256 < data.Length)
                {
                    stream.Write(data, offset, 256);
                    offset += 256;
                }
                stream.Write(data, offset, data.Length - offset);
                stream.Close();
                tcpClient.Close();

                return new OperationResult(Result.OK, "");             
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }
    }
}
