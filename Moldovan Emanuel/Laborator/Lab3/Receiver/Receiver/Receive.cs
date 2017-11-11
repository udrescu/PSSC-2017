using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Receiver
{
    class Receive
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                Console.WriteLine(" Press [x] to exit.");
                bool set = false;
                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine("                                                        ________________");
                    Console.WriteLine("                                                        |Received {0}|", message);
                    set = true;
                    Console.WriteLine("                                                        ----------------");
                };
                channel.BasicConsume(queue: "TestQueue",
                                     autoAck: true,
                                     consumer: consumer);
                bool exit = false;
                if (!set)
                {
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
                                             routingKey: "Test2Queue",
                                             basicProperties: null,
                                             body: body);
                        //Console.WriteLine("________________");
                        //Console.WriteLine("|Sent {0}|", message);
                        //Console.WriteLine("----------------");

                    }
                }
                set = false;
            }
        }

    }
}
