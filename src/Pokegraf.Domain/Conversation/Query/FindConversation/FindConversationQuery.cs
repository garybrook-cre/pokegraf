﻿using MediatR;
using OperationResult;
using Pokegraf.Common.ErrorHandling;

namespace Pokegraf.Domain.Conversation.Query.FindConversation
{
    public class FindConversationQuery : IRequest<Result<Entity.Conversation, Error>>
    {
        public long ChatId { get; set; }
        public int UserId { get; set; }
    }
}