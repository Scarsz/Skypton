﻿using PluginHandler;
using SKYPE4COMLib;

using System;

namespace Plugin_Ping
{
    public class Plugin : IPlugin
    {
        static readonly string pluginName = "Urban Dictionary";
        static readonly string pluginAuthor = "Scarsz";
        static readonly string pluginVersion = "1";
        static readonly string pluginDescription = "Gets the top definition of an Urban Dictionary phrase";
        static readonly string[] pluginCommands = { "urban" };

        public string Name { get { return pluginName; } }
        public string Author { get { return pluginAuthor; } }
        public string Version { get { return pluginVersion; } }
        public string Description { get { return pluginDescription; } }
        public string[] Commands { get { return pluginCommands; } }

        public string Main(string command, Skype skype)
        {
            string result = "";
            return result;
        }
    }
}