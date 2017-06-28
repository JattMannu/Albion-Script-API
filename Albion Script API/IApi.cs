﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Ennui.Api.Method;

namespace Ennui.Api
{
    public interface IApi
    {
        IBanking Banking { get; set; }
        IBot Bot { get; set; }
        IBotResources BotResources { get; set; }
        ICharacterInfoWindow CharacterInfoWindow { get; set; }
        ICharacterSelectWindow CharacterSelectWindow { get; set; }
        IChat Chat { get; set; }
        ICollision Collision { get; set; }
        ICraftingWindow CraftingWindow { get; set; }
        IEntities Entities { get; set; }
        IEquipment Equipment { get; set; }
        IFactories Factories { get; set; }
        IFarmableWindow FarmableWindow { get; set; }
        IFastTravelWindow FastTravelWindow { get; set; }
        IFiles Files { get; set; }
        IGame Game { get; set; }
        IHotkeys Hotkeys { get; set; }
        IInput Input { get; set; }
        IInventory Inventory { get; set; }
        IItemContainerUtils ItemContainerUtils { get; set; }
        ILogging Logging { get; set; }
        ILoginErrorWindow LoginErrorWindow { get; set; }
        ILoginWindow LoginWindow { get; set; }
        IMovement Movement { get; set; }
        INet Net { get; set; }
        IObjects Objects { get; set; }
        IPaySilverWindow PaySilverWindow { get; set; }
        IPlayers Players { get; set; }
        IRendering Rendering { get; set; }
        IRepairWindow RepairWindow { get; set; }
        ISerialization Serialization { get; set; }
        IUI UI { get; set; }
        IViews Views { get; set; }
    }
}
