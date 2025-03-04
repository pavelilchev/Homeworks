﻿namespace ByTheCake.Server.Routing.Contracts
{
    using System.Collections.Generic;
    using Handlers;

    public interface IRoutingContext
    {
		IEnumerable<string> Parameters { get; }

        RequestHandler RequestHandler { get; }
    }
}
