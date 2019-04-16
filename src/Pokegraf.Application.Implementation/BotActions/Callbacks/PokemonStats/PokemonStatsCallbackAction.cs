using Pokegraf.Application.Contract.Common.Context;
using Pokegraf.Application.Implementation.BotActions.Common;

namespace Pokegraf.Application.Implementation.BotActions.Callbacks.PokemonStats
{
    public class PokemonStatsCallbackAction : CallbackAction
    {
        public PokemonStatsCallbackAction(IBotContext botContext) : base(botContext)
        {
        }

        public override bool CanHandle(string condition)
        {
            return condition == "pokemon_stats";
        }
    }
}