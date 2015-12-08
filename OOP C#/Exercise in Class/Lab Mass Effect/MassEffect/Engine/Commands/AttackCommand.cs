namespace MassEffect.Engine.Commands
{
    using System;
    using MassEffect.Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            throw new NotImplementedException();
        }
    }
}
