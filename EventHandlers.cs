using Exiled.API.Features;
using Exiled.Events.EventArgs.Warhead;
using PlayerStatsSystem;

namespace DeadmanSwitchRemover
{
    public class EventHandlers
    {
        public readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public void DeadmenSwitchInit (DeadmanSwitchInitiatingEventArgs ev)
        {
            if (Round.ElapsedTime.TotalMinutes < plugin.Config.DelayMinutes)
            {
                ev.IsAllowed = false;
                DeadmanSwitch._dmsTime += 10f;// I know i can just reject it but this time the event is triggered 35 times per second and the logs accumulate too much
                Log.Debug("DMS has been delayed for 10 seconds because min required time is " + plugin.Config.DelayMinutes);
            }
               
        }
    }
}
