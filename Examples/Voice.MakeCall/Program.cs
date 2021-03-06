﻿using System;
using AfricasTalkingCS;
namespace Voice.MakeCall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var username = "sandbox";
            var apiKey = "afd635a4f295dd936312836c0b944d55f2a836e8ff2b63987da5e717cd5ff745";
            var from = "+254724545678";
            var to = "+254725587654";
            var gateway = new AfricasTalkingGateway(username, apiKey);

            try
            {
                var results = gateway.Call(from, to);
                Console.WriteLine(results);
            }
            catch (AfricasTalkingGatewayException exception)
            {
                Console.WriteLine("Something went horribly wrong: " + exception.Message + ".\nCaused by :" + exception.StackTrace);
            }

            Console.ReadLine();
        }
    }
}
