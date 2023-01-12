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
        // Console.WriteLine(response);
        string response = await client.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
        // Console.WriteLine(jsonAsDictionary);
        var jsonAsDictionary = System.Text.Json.JsonSerializer.Deserialize<Object>(response);
        Console.WriteLine("");
        // Console.WriteLine(jokeNode);
        JsonNode jokeNode = JsonNode.Parse(response)!;
        // setup;
        JsonNode setup = jokeNode!["setup"]!;
        Console.WriteLine(setup);
        Console.WriteLine("");
        // punchline;
        JsonNode punchline = jokeNode!["punchline"]!;
        Console.WriteLine(punchline);
        Console.WriteLine("");
    }
}