using System;
using System.Linq;
using Z.Expressions;

namespace AI_Project.Executioners
{
    public class EvaluateExecutioner : IExecutioner
    {
        public bool ToLearn { get { return true; } }
        public string Info
        {
            get
            {
                return "<b>eval arithmetic_expression</b> - Evaluates the given expression (pay attention that those are int expressions, so / is integer division and % is integer modulo).";
            }
        }

        public string Execute(string command)
        {
            var args = command.Split(new char[] { ' ' }, 2);
            if (args.Length != 2 || args[0] != "eval") return null;
            string result = null;
            try
            {
                result = args[1].Execute<int>().ToString();
            } catch (Exception)
            {
                result = null;
            }
            return result;
        }
    }
}