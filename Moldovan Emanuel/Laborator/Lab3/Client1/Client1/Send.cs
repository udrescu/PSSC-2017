using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Client1
{
    class Send
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chat");
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                Console.WriteLine(" Press [x] to exit.");
                bool exit = false;
                while (!exit)
                {
                    string message = "";
                    if ((message = Console.ReadLine()) == "x")
                    {
                        exit = true;
                        break;
                    }                        
                    else
                    {
                        exit = false;
                    }                    
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                         routingKey: "TestQueue",
                                         basicProperties: null,
                                         body: body);
                    //Console.WriteLine("________________");
                    //Console.WriteLine("|Sent {0}|", message);
                    //Console.WriteLine("----------------");

                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        body = ea.Body;
                        message = Encoding.UTF8.GetString(body);
                        Console.WriteLine("                                                        ________________");
                        Console.WriteLine("                                                        |Received {0}|", message);
                        Console.WriteLine("                                                        ----------------");
                    };
                    channel.BasicConsume(queue: "Test2Queue",
                                         autoAck: true,
                                         consumer: consumer);                    
                }                
            }    

        }
    }
}
