namespace MassEffect.Engine.Commands
{
    using System;
    using MassEffect.Interfaces;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine) 
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            throw new NotImplementedException();
        }
    }
}
