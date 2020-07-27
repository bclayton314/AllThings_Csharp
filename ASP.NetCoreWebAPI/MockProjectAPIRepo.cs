using System.Collections.Generic;
using ProjectAPI.Models;

namespace ProjectAPI.Data
{
    public class MockProjectAPIRepo : IProjectAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Something", Line="Something Else", Platform="Whatever"},
                new Command{Id=1, HowTo="here we go", Line="lets do this", Platform="Thing to do"},
                new Command{Id=2, HowTo="Go again", Line="We did it", Platform="Something Something"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Something", Line="Something Else", Platform="Whatever"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}