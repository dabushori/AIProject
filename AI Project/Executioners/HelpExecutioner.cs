namespace AI_Project.Executioners
{
    public class HelpExecutioner : IExecutioner
    {
        private CommandExecutioner excecutioner;
        public bool ToLearn { get { return false; } }
        public HelpExecutioner(CommandExecutioner excecutioner)
        {
            this.excecutioner = excecutioner;
        }
        public string Execute(string command)
        {
            if (command != "help")
            {
                return null;
            }
            return excecutioner.HelpString;
        }

        public string Info
        {
            get
            {
                return "<b>help</b> - shows a list of commands you can use.";
            }
        }
    }
}