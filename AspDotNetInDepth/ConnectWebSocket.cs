using System.Net.WebSockets;

namespace AspDotNetInDepth
{
    public class ConnectWebSocket
    {
        public async Task ConnectWebSocketAsync()
        {
            using ClientWebSocket client = new ClientWebSocket();
            Uri serverUri = new Uri("ws://localhost:7176/ws");

            await client.ConnectAsync(serverUri, CancellationToken.None);

            Console.WriteLine("Connected!");
            // Now you can send and receive messages.
        }
    }
}
