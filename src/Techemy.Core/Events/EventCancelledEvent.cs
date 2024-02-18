using System;
using Abp.Events.Bus.Entities;

namespace Techemy.Events
{
    public class EventCancelledEvent : EntityEventData<Event>
    {
        public EventCancelledEvent(Event entity)
            : base(entity)
        {
        }
    }
}

