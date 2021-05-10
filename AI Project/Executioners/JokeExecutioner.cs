using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace AI_Project.Executioners
{
    public class JokeExecutioner : IExecutioner
    {
        private string appDataDir;
        public string Info
        {
            get
            {
                return "<b>joke</b> - Tells a random (hilarious) joke.";
            }
        }
        public bool ToLearn { get { return false; } }
        public JokeExecutioner(string add)
        {
            appDataDir = add;
        }

        public class Joke
        {
            public string body;
            public string id;
            public int score;
            public string title;
        }

        Random rand = new Random();

        public string Execute(string command)
        {
            if (command != "joke") return null;
            using (StreamReader r = new StreamReader(Path.Combine(appDataDir, "jokes.json")))
            {
                string json = r.ReadToEnd();
                List<Joke> items = JsonConvert.DeserializeObject<List<Joke>>(json);
                Joke jo = items[rand.Next(items.Count)];
                return jo.title + "<br/>" + jo.body;
            }
        }
    }
}