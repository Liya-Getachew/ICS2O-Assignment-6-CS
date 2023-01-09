// Created by: liya getachew
// Created on: Jan 2023
//
// This program accepts user input

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    public static async Task Main()
    {
        // This function shows the current weather
        HttpClient client = new HttpClient();
        string response = await client.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
        // Console.WriteLine(response);
        var jsonAsDictionary = System.Text.Json.JsonSerializer.Deserialize<Object>(response);
        // Console.WriteLine(jsonAsDictionary);
        Console.WriteLine("");
        JsonNode jokeNode = JsonNode.Parse(response)!;
        // Console.WriteLine(forecastNode);
        JsonNode setup = jokeNode!["setup"]!;
        // Console.WriteLine(mainNode);
        Console.WriteLine(setup);
        Console.WriteLine("");
        // Console.WriteLine(forecastNode);
        JsonNode punchline = jokeNode!["punchline"]!;
        // Console.WriteLine(main1Node);
        Console.WriteLine(punchline);
        Console.WriteLine("");
    }
}