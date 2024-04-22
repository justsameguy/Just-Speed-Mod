using HarmonyLib;
using GameNetcodeStuff;
using System;

namespace MyMod.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void InfiniteSprintPatch(PlayerControllerB __instance)
        {
            __instance.sprintMeter = 1f;
        }

        [HarmonyPatch("movementSpeed")]
        [HarmonyPostfix]
        static void MovementSpeedPatch(PlayerControllerB __instance)
        {
            __instance.movementSpeed = 2f;
        }

        [HarmonyPatch("climbSpeed")]
        [HarmonyPostfix]
        static void ClimbSpeedPatch(PlayerControllerB __instance)
        {
            __instance.climbSpeed = 8f;
        }
    }
}
