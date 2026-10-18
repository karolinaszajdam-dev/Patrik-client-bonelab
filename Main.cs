using MelonLoader;
using UnityEngine;

namespace PatrikClient
{
    internal partial class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("PATRIK CLIENT loaded: starter only; menu/gameplay features are not connected yet.");
        }

        public override void OnUpdate()
        {
            // Next step: add a VR UI using APIs and assemblies compatible with the installed BONELAB build.
            // Keep gameplay feature handlers separate and verify each API before enabling it.
        }
    }
}
