using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_signalR_console
{
    internal class MainClient
    {
        public static async Task ExecuteAsync()
        {
            //Replace port "7024" with the port running the MainSignalServer project
            var uri = "https://localhost:7024/current-time";
            await using var connection = new HubConnectionBuilder().WithUrl(uri).Build();
            await connection.StartAsync();
            await foreach (var date in connection.StreamAsync<DateTime>("Streaming"))
            {
                Console.WriteLine(date);
            }
        }
    }
}
