//12.Write a program that parses an URL address given in the format:

//[protocol]://[server]/[resource]

//and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php 
//the following information should be extracted:

//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

using System;

    class ParseURL
    {
        static void Main(string[] args)
        {
            string URL = "http://www.devbg.org/forum/index.php ";

            string protocol = URL.Substring(0, URL.IndexOf(':', 0));

            int firstIndex = URL.IndexOf(':', 0) + 3;
            int secondIndex = URL.IndexOf('/', firstIndex);

            string server = URL.Substring(firstIndex, secondIndex - firstIndex);
            string resource = URL.Substring(secondIndex);

            Console.WriteLine("[protocol] = " + protocol);
            Console.WriteLine("[server] = " + server);
            Console.WriteLine("[resource] = " + resource);

            Console.WriteLine();
        }
    }

