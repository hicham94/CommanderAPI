using CommanderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
            new Command() { Id = 0, HowTo = "boil eggs", Line = "boil watter", Plateform = "palt & plat" },
            new Command() { Id = 1, HowTo = "boil", Line = "watter", Plateform = "& plat" },
            new Command() { Id = 2, HowTo = " eggs", Line = "boil", Plateform = "palt & " }
            };

            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command() {Id = 0, HowTo="boil eggs", Line="boil watter", Plateform="palt & plat" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
