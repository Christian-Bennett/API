using System;
using System.Collections.Generic;
using System.Net.Http;

namespace MovieInfo.Client
{
    class Program
    {
        static void Main(string[] args)
    {
      HttpClient client = new HttpClient();

      var res = client.GetAsync("http://localhost:5000/SW").GetAwaiter().GetResult();

      System.Console.WriteLine(res);

      Console.ReadLine();
    }
    }
}
