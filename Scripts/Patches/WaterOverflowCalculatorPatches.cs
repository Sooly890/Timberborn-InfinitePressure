using System.Reflection.Emit;

using Timberborn.WaterSystem;
using HarmonyLib;

namespace Sooly890.InfinitePressure.Patches {

  [HarmonyPatch(typeof(WaterOverflowCalculator))]
  public static class WaterOverflowCalculatorPatches {

    [HarmonyPostfix, HarmonyPatch(typeof(WaterOverflowCalculator), nameof(WaterOverflowCalculator.Load))]
    public static void SetMaxPressureToInfinity(WaterOverflowCalculator __instance) {
      __instance._maxPressure = float.PositiveInfinity;
    }

  }
}