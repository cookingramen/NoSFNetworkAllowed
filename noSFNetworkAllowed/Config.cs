using System.ComponentModel;
using System.Collections.Generic;
using Exiled.API.Interfaces;
using Exiled.API.Enums;

namespace noSFNetworkAllowed
{
    public sealed class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled on this server.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Kick reason")]
        public string KickReason { get; set; } = "Tajemniczy to Furry";
    }
}