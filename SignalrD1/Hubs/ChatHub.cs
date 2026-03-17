using Microsoft.AspNetCore.SignalR;

namespace SignalrD1.Hubs
{
    public class ChatHub : Hub
    {

        // This method will be called by clients to send a message
        // It takes the sender's name and the message as parameters
        // It will save the message in the database (not implemented here) and then broadcast it to all connected clients
        // The Clients property is provided by the Hub base class and allows us to send messages to clients
        // The SendAsync method takes the name of the client method to call ("NewMessage") and the parameters to pass to that method (name and message)
        // The client method "NewMessage" will be defined in the JavaScript code on the client side to handle incoming messages
        // For example, in JavaScript, we might have something like:    
        // connection.on("NewMessage", function(name, message) {
        //    // code to display the message in the chat UI
        // });
        
        public void SendMessage(string name, string message)
        {
            // save in database


            // broadcast to all clients
            Clients.All.SendAsync("NewMessage", name, message);
        }
    }
}
