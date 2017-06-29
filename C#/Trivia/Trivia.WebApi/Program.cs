﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace Trivia.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var url = "http://localhost:80/Temporary_Listen_Addresses/";
            using (var host = new NancyHost(new Uri(url)))
            {
                host.Start();
                Console.WriteLine("Running on " + url);
                Console.ReadLine();
            }
        }
    }
}
