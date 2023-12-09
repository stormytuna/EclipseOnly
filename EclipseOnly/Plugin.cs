using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace EclipseOnly
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class EclipseOnlyBase : BaseUnityPlugin
    {
        public const string ModGUID = "stormytuna.EclipseOnly";
        public const string ModName = "EclipseOnly";
        public const string ModVersion = "1.0.0";

        public static ManualLogSource Log = BepInEx.Logging.Logger.CreateLogSource(ModGUID);
        public static EclipseOnlyBase Instance;

        private readonly Harmony harmony = new Harmony(ModGUID);

        private void Awake() {
            if (Instance is null) {
                Instance = this;
            }

            Log.LogInfo("Eclipse Only has awoken!");

            harmony.PatchAll();
        }
    }
}
