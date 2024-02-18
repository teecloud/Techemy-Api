﻿using System;
using Abp.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techemy.Authorization.Users;

namespace Techemy.Events
{
    public interface IEventManager : IDomainService
    {
        Task<Event> GetAsync(Guid id);

        Task CreateAsync(Event @event);

        void Cancel(Event @event);

        Task<EventRegistration> RegisterAsync(Event @event, User user);

        Task CancelRegistrationAsync(Event @event, User user);

        Task<IReadOnlyList<User>> GetRegisteredUsersAsync(Event @event);
    }
}

