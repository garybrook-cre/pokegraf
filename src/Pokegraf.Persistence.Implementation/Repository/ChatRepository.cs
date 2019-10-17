﻿using Pokegraf.Domain.Entity;
using Pokegraf.Persistence.Contract.Context;
using Pokegraf.Persistence.Contract.Repository;

namespace Pokegraf.Persistence.Implementation.Repository
{
    public class ChatRepository : GenericRepository<Chat>, IChatRepository
    {
        public ChatRepository(IPokegrafDbContext dbContext) : base(dbContext)
        {
        }
    }
}