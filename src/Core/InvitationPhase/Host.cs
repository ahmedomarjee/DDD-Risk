﻿namespace Core.InvitationPhase
{
    using System;

    public class Host
    {
        public Host(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; private set; }

        public Guid Id { get; private set; }
    }
}