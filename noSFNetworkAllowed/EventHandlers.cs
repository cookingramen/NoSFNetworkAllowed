using System.Collections.Generic;
using System.Linq;
using Exiled.Events.EventArgs;

namespace noSFNetworkAllowed
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void IsSFNetwork(VerifiedEventArgs ev)
        {
            if (ev.Player.Nickname.ToLower.Contains("#sfnetwork"))
            {
                ev.Player.Kick(plugin.Config.KickReason);
            }
        }
    }
}
