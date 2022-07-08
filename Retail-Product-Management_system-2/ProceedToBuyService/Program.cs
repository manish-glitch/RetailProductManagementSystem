using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using ProceedToBuyRepository.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceedToBuyService
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
                var contectOptions = new DbContextOptionsBuilder<ProceedToBuyDBContext>().UseSqlServer(@"Server=.; Database=ProceedToBuyDB; integrated security=true").Options;
                var dbContext = new ProceedToBuyDBContext(contectOptions);
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                var data = JObject.Parse(message);
                var type = ea.RoutingKey;
                if (type == "vendorStock.add")
                {
                    try
                    {
                        dbContext.VendorStocks.Add(new VendorStock() { VendorId = data["VendorId"].Value<string>(), StockInHand = data["StockInHand"].Value<int>(), ProductId = data["ProductId"].Value<string>() });
                        //dbContext.Products.Add(new Product() { ProductId = data["ProductId"].Value<string>()});
                        //dbContext.Vendors.Add(new Vendor() { VendorId = data["VendorId"].Value<string>() });
                        dbContext.SaveChanges();

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("error");
                    }
                }
                if (type == "product.add")
                {
                    try
                    {
                        dbContext.Products.Add(new Product() { ProductId = data["ProductId"].Value<string>() });
                        dbContext.SaveChanges();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("error");
                    }
                }
                if (type == "vendor.add")
                {
                    try
                    {
                        dbContext.Vendors.Add(new Vendor() { VendorId = data["VendorId"].Value<string>() });
                        dbContext.SaveChanges();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("error");
                    }
                }
                /*if (type == "batch.delete")
                {
                    Batch btchdel = dbContext.Batches.First(b => b.BatchId == data["BatchId"].Value<string>());
                    dbContext.Batches.Remove(btchdel);
                    dbContext.SaveChanges();
                }*/
            };
            channel.BasicConsume(queue: "vendorStock.proceedToBuysvc", autoAck: true, consumer: consumer);
            channel.BasicConsume(queue: "product.proceedToBuysvc", autoAck: true, consumer: consumer);
            channel.BasicConsume(queue: "vendor.proceedToBuysvc", autoAck: true, consumer: consumer);
        }
    }
}
