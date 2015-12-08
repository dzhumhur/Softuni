namespace MassEffect.Engine.Commands
{
    using System;
    using MassEffect.Interfaces;

    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            throw new NotImplementedException();
        }
    }
}
