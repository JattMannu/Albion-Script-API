using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api
{
    public static class IApiExtensions
    {
        public static void Set(this IApi from, IApi to)
        {
            from.Banking = to.Banking;
            from.Bot = to.Bot;
            from.BotResources = to.BotResources;
            from.CharacterInfoWindow = to.CharacterInfoWindow;
            from.CharacterSelectWindow = to.CharacterSelectWindow;
            from.Chat = to.Chat;
            from.Codecs = to.Codecs;
            from.Collision = to.Collision;
            from.CraftingWindow = to.CraftingWindow;
            from.Entities = to.Entities;
            from.Equipment = to.Equipment;
            from.Factories = to.Factories;
            from.FarmableWindow = to.FarmableWindow;
            from.FastTravelWindow = to.FastTravelWindow;
            from.Files = to.Files;
            from.Game = to.Game;
            from.Graphs = to.Graphs;
            from.Hotkeys = to.Hotkeys;
            from.Input = to.Input;
            from.Inventory = to.Inventory;
            from.ItemContainerUtils = to.ItemContainerUtils;
            from.Logging = to.Logging;
            from.LoginErrorWindow = to.LoginErrorWindow;
            from.LoginWindow = to.LoginWindow;
            from.Movement = to.Movement;
            from.Net = to.Net;
            from.Objects = to.Objects;
            from.PaySilverWindow = to.PaySilverWindow;
            from.Players = to.Players;
            from.Rendering = to.Rendering;
            from.RepairWindow = to.RepairWindow;
            from.Serialization = to.Serialization;
            from.UI = to.UI;
            from.Views = to.Views;

            from.ScriptLoader = to.ScriptLoader;
            from.ScriptEngine = to.ScriptEngine;
        }
    }
}
