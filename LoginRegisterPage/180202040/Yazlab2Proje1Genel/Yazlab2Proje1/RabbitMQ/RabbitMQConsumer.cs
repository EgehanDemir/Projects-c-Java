using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Yazlab2Proje1.RabbitMQ
{
    public class RabbitMQConsumer
    {
        public void RabbbitMQ()
         {
            var factory = new ConnectionFactory
             {
                 Uri = new Uri("amqp://guest:guest@localhost:5672"),

             };
             using var connection = factory.CreateConnection();
             using var channel = connection.CreateModel();
             channel.QueueDeclare("demo-queue,", durable:true, exclusive:false,autoDelete:false,arguments:null);
             var consumer = new EventingBasicConsumer(channel);
             consumer.Received += (sender, e) => {
                 var body = e.Body.ToArray();
                 var message = Encoding.UTF8.GetString(body);
                 Console.WriteLine(message); 
             };
             channel.BasicConsume("demo-queue", true, consumer);
             Console.ReadLine();         
             
        }
    }
}