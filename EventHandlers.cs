using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Warhead;

namespace DeadmanSwitchRemover
{
    public class EventHandlers
    {
        public readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void OnWarheadStart(StartingEventArgs ev)
        {
            if ( ev.IsAuto && DeadmanSwitch._dmsActive)
            {
                ev.IsAllowed = false;   
                Log.Debug("Auto warhead tried to start when dms was open auto canceled");
            }
        }

        public void DeadmenSwitchInit(DeadmanSwitchInitiatingEventArgs ev)
        {
            if ( Warhead.IsInProgress && Warhead.IsLocked)
            {
                StaticUnityMethods.OnUpdate -= (Action)DeadmanSwitch.OnUpdate;
                ev.IsAllowed = false;
                Log.Debug("Automatic warhead has already started, dms is disabled");
                return;
            }

            if (plugin.Config.MinimumStartMinutes== 0)
                return;

            if ( Round.ElapsedTime.TotalMinutes < plugin.Config.MinimumStartMinutes )
            {
                ev.IsAllowed = false;
                DeadmanSwitch._dmsTime += 5f;
                Log.Debug("DMS has been delayed 5 seconds");
            }
        }
    }
}
