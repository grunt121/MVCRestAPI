using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command command)
        {
            if(command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _context.Commands.Add(command);

        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        IEnumerable<Command> ICommanderRepo.GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        Command ICommanderRepo.GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(a => a.Id == id);
        }
    }
}
