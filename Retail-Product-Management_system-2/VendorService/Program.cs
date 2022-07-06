using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRepository.Models;

namespace VendorService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListenForIntegrationEvent();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        private static void ListenForIntegrationEvent()
        {
            var factory = new ConnectionFactory();
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();
            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (mode, ea) =>
            {
                var contectOptions = new DbContextOptionsBuilder<VendorDBContext>().UseSqlServer(@"Server=.; Database=VendorDB; integrated security=true").Options;
                var dbContext = new VendorDBContext(contectOptions);
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                var data = JObject.Parse(message);
                var type = ea.RoutingKey;
                if (type == "product.add")
                {
                    try
                    {
                        dbContext.Products.Add(new Product() { ProductId = data["ProductId"].Value<string>(), ProductName = data["ProductName"].Value<string>() });
                        dbContext.SaveChanges();

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("error");
                    }
                }
                
            };
            channel.BasicConsume(queue: "product.vendorsvc", autoAck: true, consumer: consumer);
        }
    }
}
