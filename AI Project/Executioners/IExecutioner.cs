namespace AI_Project.Executioners
{
    interface IExecutioner
    {
        // a method that excecutes the command, return null if the command is wrong
        string Execute(string command);
        string Info { get; }

        bool ToLearn { get; }
    }
}
