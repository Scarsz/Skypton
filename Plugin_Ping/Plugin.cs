﻿using PluginHandler;
using SKYPE4COMLib;

using System;

namespace Plugin_Ping
{
    public class Plugin : IPlugin
    {
        static readonly string pluginName = "Ping!";
        static readonly string pluginAuthor = "Scarsz";
        static readonly string pluginVersion = "1";
        static readonly string pluginDescription = "Pong!";
        static readonly bool pluginAdminOnly = false;
        static readonly string[] pluginCommands = { "ping" };

        public string Name { get { return pluginName; } }
        public string Author { get { return pluginAuthor; } }
        public string Version { get { return pluginVersion; } }
        public string Description { get { return pluginDescription; } }
        public bool AdminOnly { get { return pluginAdminOnly; } }
        public string[] Commands { get { return pluginCommands; } }

        public string Main(string command, string sender, Skype skype)
        {
            return "Pong!";
        }
    }
}