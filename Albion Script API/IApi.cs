using Ennui.Api.Method;
using Ennui.Api.Script;
using Ennui.Api.Gui;

namespace Ennui.Api
{
    /// <summary>
    /// Provides services related to botting.
    /// </summary>
    public interface IApi
    {
        IBanking Banking { get; set; }
        IBot Bot { get; set; }
        IBotResources BotResources { get; set; }
        ICharacterInfoWindow CharacterInfoWindow { get; set; }
        ICharacterSelectWindow CharacterSelectWindow { get; set; }
        IChat Chat { get; set; }
        ICodecs Codecs { get; set; }
        ICollision Collision { get; set; }
        ICraftingWindow CraftingWindow { get; set; }
        IEntities Entities { get; set; }
        IEquipment Equipment { get; set; }
        IExpeditionWindow ExpeditionWindow { get; set; }
        IFactories Factories { get; set; }
        IFarmableWindow FarmableWindow { get; set; }
        IFastTravelWindow FastTravelWindow { get; set; }
        IFiles Files { get; set; }
        IGame Game { get; set; }
        IGeometryUtils GeometryUtils { get; set; }
        IGoldMarketWindow GoldMarketWindow { get; set; }
        IGraphs Graphs { get; set; }
        IHotkeys Hotkeys { get; set; }
        IInput Input { get; set; }
        IInventory Inventory { get; set; }
        ILogging Logging { get; set; }
        ILoginErrorWindow LoginErrorWindow { get; set; }
        ILoginWindow LoginWindow { get; set; }
        IMarket Market { get; set; }
        IMovement Movement { get; set; }
        INet Net { get; set; }
        IObjects Objects { get; set; }
        IPaySilverWindow PaySilverWindow { get; set; }
        IPlayers Players { get; set; }
        IRendering Rendering { get; set; }
        IRepairWindow RepairWindow { get; set; }
        IResourceRepository ResourceRepository { get; set; }
        ISerialization Serialization { get; set; }
        IUI UI { get; set; }
        IViews Views { get; set; }

        IGuiScene GuiScene { get; set; }

        IScriptLoader ScriptLoader { get; set; }
        IScriptEngine ScriptEngine { get; set; }
    }
}
