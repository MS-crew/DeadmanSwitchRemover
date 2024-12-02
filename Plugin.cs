using System;
using Exiled.API.Features;

namespace DeadmanSwitchRemover
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        public override string Author => "ZurnaSever";

        public override string Name => "DmsRemover";

        public override string Prefix => "DmsRemover";

        public override Version RequiredExiledVersion { get; } = new Version(9, 0, 0);

        public override Version Version { get; } = new Version(1, 0, 0);
        public override void OnEnabled()
        {
            Instance = this;
            StaticUnityMethods.OnUpdate -= (Action)DeadmanSwitch.OnUpdate;
            Log.Debug("Deadman Fck Youuu!!! Get out of here!");
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            base.OnDisabled();
        }
    }
}
