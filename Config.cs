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
        [Description("Deadman switch should wait at least how many minutes to start? ")]
        public int MinimumStartMinutes { get; set; } = 15;
    }
}
