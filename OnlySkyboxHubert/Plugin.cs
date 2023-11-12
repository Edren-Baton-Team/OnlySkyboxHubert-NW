using Exiled.API.Features;
using HarmonyLib;
using PluginAPI.Core.Attributes;
using System;

namespace OnlySkyboxHubert
{
    public class Plugin
    {
        [PluginConfig("configs/only-skybox-hubert.yml")]
        public static Config Config;
        internal Harmony harmony;
        [PluginEntryPoint("OnlySkyboxHubert", "1.0.0", "", "Rysik5318")]
        void LoadPlugin()
        {
            harmony = new Harmony($"OnlySkyboxHubert - {DateTime.Now}");
            harmony.PatchAll();
        }
    }
}
