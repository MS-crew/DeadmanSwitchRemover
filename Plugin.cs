using System;
using Exiled.API.Features;
using Warhead = Exiled.Events.Handlers.Warhead;

namespace DeadmanSwitchRemover
{
    public class Plugin : Plugin<Config>
    {
        public static EventHandlers eventHandlers;
        public static Plugin Instance { get; private set; }
        public override string Author => "ZurnaSever";
        public override string Name => "DmsController";
        public override string Prefix => "DmsController";
        public override Version RequiredExiledVersion { get; } = new Version(9, 5, 1);
        public override Version Version { get; } = new Version(1, 5, 2);

        public override void OnEnabled()
        {
            Instance = this;

            if (!Config.PermenantlyRemove) 
            {
                eventHandlers = new EventHandlers(this); 
                Warhead.Starting += eventHandlers.OnWarheadStart;
                Warhead.DeadmanSwitchInitiating += eventHandlers.DeadmenSwitchInit;
            }

            else 
            { 
                StaticUnityMethods.OnUpdate -= (Action)DeadmanSwitch.OnUpdate;
                Log.Debug("DMS has been permanently disabled");
            }

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            if (!Config.PermenantlyRemove)
            {
                Warhead.Starting -= eventHandlers.OnWarheadStart;
                Warhead.DeadmanSwitchInitiating -= eventHandlers.DeadmenSwitchInit;
            }
            
            eventHandlers = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}
