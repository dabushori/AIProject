using System;
using System.Net;
using System.Web;

namespace AI_Project.Executioners
{
    public class TranslateExecutioner : IExecutioner
    {
        public bool ToLearn { get { return false; } }
        public string Execute(string command)
        {
            var args = command.Split(new char[] { ' ' }, 4);
            if (args.Length != 4 || args[0] != "translate")
            {
                return null;
            }
            return Translate(args[3], args[2], args[1]);

        }

        private string Translate(string word, string toLanguage, string fromLanguage)
        {
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public string Info
        {
            get
            {
                return "<b>translate from_lang to_lang string_to_translate</b> - Translates a string between two languages.";
            }
        }
    }
}