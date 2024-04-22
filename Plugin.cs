using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using MyMod.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class ModBase : BaseUnityPlugin
    {
        private const string modGUID = "FirstMod.JustMod";
        private const string modName = "Just Speed Buffs";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static ModBase Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);


            mls.LogInfo("This shit is working :D");

            harmony.PatchAll(typeof(ModBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }
    }
}
