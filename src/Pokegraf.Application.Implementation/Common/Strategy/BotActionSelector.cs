using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Pokegraf.Application.Contract.Common.Context;
using Pokegraf.Application.Contract.Common.Strategy;
using Pokegraf.Application.Contract.Model;
using Pokegraf.Application.Contract.Model.Action;
using Pokegraf.Application.Contract.Model.Action.Callback;
using Pokegraf.Application.Contract.Model.Action.Command;
using Pokegraf.Application.Contract.Model.Action.Conversation;
using Pokegraf.Application.Contract.Model.Action.Inline;
using Pokegraf.Application.Implementation.Mapping.Extension;
using Pokegraf.Common.Result;
using Pokegraf.Infrastructure.Contract.Model;
using Pokegraf.Infrastructure.Contract.Service;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Pokegraf.Application.Implementation.Common.Strategy
{
    public class BotActionSelector : IBotActionSelector
    {
        protected readonly ILogger<BotActionSelector> Logger;
        protected readonly IStrategyContext StrategyContext;
        protected readonly IBotContext BotContext;

        public BotActionSelector(ILogger<BotActionSelector> logger, IStrategyContext strategyContext, IBotContext botContext)
        {
            Logger = logger;
            StrategyContext = strategyContext;
            BotContext = botContext;
        }

        public Result<ICommandAction> GetCommandAction()
        {            
            var command = GetCommand(BotContext.Message);
            
            if (command == null) return Result<ICommandAction>.NotFound(new List<string> {"No corresponding action found."});

            var action = StrategyContext.GetCommandStrategyContext().FirstOrDefault(botAction => botAction.CanHandle(command));

            if (action == null) return Result<ICommandAction>.NotFound(new List<string> {"No corresponding action found."});

            return Result<ICommandAction>.Success(action);
        }

        public Result<IConversationAction> GetConversationAction()
        {
            var intent = BotContext.Intent;
            
            if (intent == null) return Result<IConversationAction>.NotFound(new List<string> {"No corresponding action found."});
            
            var action = StrategyContext.GetConversationStrategyContext().FirstOrDefault(botAction => botAction.CanHandle(intent.Action));
            
            if (action == null) return Result<IConversationAction>.NotFound(new List<string> {"No corresponding action found."});

            return Result<IConversationAction>.Success(action);
        }

        public Result<ICallbackAction> GetCallbackAction()
        {
            var callback = GetCallback(BotContext.CallbackQuery);
            
            if (callback == null) return Result<ICallbackAction>.NotFound(new List<string> {"No corresponding action found."});

            var action = StrategyContext.GetCallbackStrategyContext().FirstOrDefault(botAction => botAction.CanHandle(callback));
            
            if (action == null) return Result<ICallbackAction>.NotFound(new List<string> {"No corresponding action found."});

            return Result<ICallbackAction>.Success(action);
        }

        public Result<IInlineAction> GetInlineAction()
        {
            var inline = BotContext.InlineQuery.Query;
            
            if (inline == null) return Result<IInlineAction>.NotFound(new List<string> {"No corresponding action found."});

            var action = StrategyContext.GetInlineStrategyContext().FirstOrDefault(botAction => botAction.CanHandle(inline));
            
            if (action == null) return Result<IInlineAction>.NotFound(new List<string> {"No corresponding action found."});

            return Result<IInlineAction>.Success(action);
        }

        private string GetCommand(Message message)
        {
            if (message.Entities?.First()?.Type != MessageEntityType.BotCommand) return null;
            
            var command = message.EntityValues.First();

            if (!command.Contains('@')) return command;
                
            if (!command.ToLower().Contains("@pokegraf_bot")) return null;

            command = command.Substring(0, command.IndexOf('@'));

            return command;
        }

        private string GetCallback(CallbackQuery callbackQuery)
        {
            try
            {
                var callbackData = JsonConvert.DeserializeObject<Dictionary<string, string>>(callbackQuery.Data);

                return callbackData["action"];
            }
            catch
            {
                return null;
            }
        }
    }
}