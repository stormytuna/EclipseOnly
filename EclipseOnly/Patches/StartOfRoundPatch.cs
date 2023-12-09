using HarmonyLib;

namespace EclipseOnly.Patches
{
    [HarmonyPatch(typeof(StartOfRound))]
    public class StartOfRoundPatch
    {
        [HarmonyPrefix, HarmonyPatch(nameof(StartOfRound.SetPlanetsWeather))]
        public static bool MakePlanetsEclipsed(SelectableLevel[] ___levels) {
            foreach (SelectableLevel level in ___levels) {
                level.currentWeather = LevelWeatherType.Eclipsed;
            }

            return false; // Want to completely replace functionality of this method, so no need to run the original
        }
    }
}
