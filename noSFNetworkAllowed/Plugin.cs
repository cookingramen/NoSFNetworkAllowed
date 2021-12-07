using System;
using System.Collections.Generic;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using Server = Exiled.Events.Handlers.Server;

namespace noSFNetworkAllowed
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;
        public EventHandlers EventHandlers;

        public override string Name => "NoSFNetworkAllowed";
        public override string Author => "cookingramen";
        public override string Prefix => "NSFNA";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(4, 0, 0);

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandlers = new EventHandlers(this);
            Player.Verified += EventHandlers.IsSFNetwork;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Singleton = null;
            EventHandlers = null;
            Player.Verified -= EventHandlers.IsSFNetwork;
            base.OnDisabled();
        }
    }
}