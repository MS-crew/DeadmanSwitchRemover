using Exiled.API.Interfaces;
using System.ComponentModel;

namespace DeadmanSwitchRemover
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Should DMS be permanently disabled?")]
        public bool PermenantlyRemove { get; set; } = true;
        [Description("How many minutes into the round should DMS remain disabled?")]
        public int DelayMinutes { get; set; } = 15;
    }
}
