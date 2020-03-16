﻿using Navigator.Abstraction;
using Navigator.Extensions.Actions;

namespace Pokegraf.Core.Domain.Actions.Command.Fusion
{
    public class FusionCommandAction : CommandAction
    {
        public override bool CanHandle(INavigatorContext ctx)
        {
            return Command.ToLower() == "/fusion";
        }
    }
}