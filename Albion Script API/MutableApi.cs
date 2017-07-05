﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ennui.Api.Method;
using Ennui.Api.Script;

namespace Ennui.Api
{
    public class MutableApi : IApi
    {
        public IBanking Banking { get; set; }
        public IBot Bot { get; set; }
        public IBotResources BotResources { get; set; }
        public ICharacterInfoWindow CharacterInfoWindow { get; set; }
        public ICharacterSelectWindow CharacterSelectWindow { get; set; }
        public IChat Chat { get; set; }
        public ICodecs Codecs { get; set; }
        public ICollision Collision { get; set; }
        public ICraftingWindow CraftingWindow { get; set; }
        public IEntities Entities { get; set; }
        public IEquipment Equipment { get; set; }
        public IFactories Factories { get; set; }
        public IFarmableWindow FarmableWindow { get; set; }
        public IFastTravelWindow FastTravelWindow { get; set; }
        public IFiles Files { get; set; }
        public IGame Game { get; set; }
        public IHotkeys Hotkeys { get; set; }
        public IInput Input { get; set; }
        public IInventory Inventory { get; set; }
        public IItemContainerUtils ItemContainerUtils { get; set; }
        public ILogging Logging { get; set; }
        public ILoginErrorWindow LoginErrorWindow { get; set; }
        public ILoginWindow LoginWindow { get; set; }
        public IMovement Movement { get; set; }
        public INet Net { get; set; }
        public IObjects Objects { get; set; }
        public IPaySilverWindow PaySilverWindow { get; set; }
        public IPlayers Players { get; set; }
        public IRendering Rendering { get; set; }
        public IRepairWindow RepairWindow { get; set; }
        public ISerialization Serialization { get; set; }
        public IUI UI { get; set; }
        public IViews Views { get; set; }

        public IScriptLoader ScriptLoader { get; set; }
        public IScriptEngine ScriptEngine { get; set; }
    }
}