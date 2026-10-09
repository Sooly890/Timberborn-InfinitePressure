using HarmonyLib;
using Timberborn.ModManagerScene;

namespace Sooly890.InfinitePressure
{ 
  public class MStarter : IModStarter
  {
    public void StartMod(IModEnvironment modEnvironment)
    {
      new Harmony(nameof(Sooly890.InfinitePressure)).PatchAll();
    }
  }
}

