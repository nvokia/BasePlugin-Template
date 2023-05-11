using System;
using UnityEngine;
using BepInEx;

namespace BasePlugin
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class BasePlugin : BaseUnityPlugin
    {
        public const string pluginGuid = "com.github.SZAAAAAA.BasePlugin";
        public const string pluginName = "Base Plugin";
        public const string pluginVersion = "1.0.0";

        public void Awake()
        {
            Logger.LogInfo("BasePlugin loaded");
        }
        public void Start()
        {
            Logger.LogInfo("BasePlugin started");
        }
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                Logger.LogInfo("F1 pressed");
            }
        }
        public void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 100, 20), "Hello World!");
        }
    }
}
