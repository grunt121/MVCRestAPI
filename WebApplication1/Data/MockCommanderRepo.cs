using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo: ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id=0, HowTo = "Boil An Egg", Line = "Boil water", Platform = "Kettle & Pan"},
                new Command { Id = 1, HowTo = "Vut Bread", Line = "Bread", Platform = "bread" },
                new Command { Id = 2, HowTo = "Cup of tea", Line = "Boil water", Platform = "cot" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id=0, HowTo = "Boil An Egg", Line = "Boil water", Platform = "Kettle & Pan"};
        }
    }
}