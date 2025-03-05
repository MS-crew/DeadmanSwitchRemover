using System;
using Exiled.API.Features;

namespace DeadmanSwitchRemover
{
    public class Plugin : Plugin<Config>
    {
        public static EventHandlers eventHandlers;
        public static Plugin Instance { get; private set; }

        public override string Author => "ZurnaSever";

        public override string Name => "DmsRemover";

        public override string Prefix => "DmsRemover";

        public override Version RequiredExiledVersion { get; } = new Version(9, 5, 1);

        public override Version Version { get; } = new Version(1, 5, 0);
        public override void OnEnabled()
        {
            Instance = this;
            eventHandlers = new EventHandlers(this);
            if (!Config.PermenantlyRemove) Exiled.Events.Handlers.Warhead.DeadmanSwitchInitiating += eventHandlers.DeadmenSwitchInit;
            else 
            { 
                StaticUnityMethods.OnUpdate -= (Action)DeadmanSwitch.OnUpdate; 
                Log.Debug("DMS has been permanently disabled");
            }
            
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            if (!Config.PermenantlyRemove) Exiled.Events.Handlers.Warhead.DeadmanSwitchInitiating -= eventHandlers.DeadmenSwitchInit;
            eventHandlers = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}
