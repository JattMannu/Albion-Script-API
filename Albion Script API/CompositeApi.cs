using Ennui.Api.Gui;
using Ennui.Api.Method;
using Ennui.Api.Script;

namespace Ennui.Api
{
    public class CompositeApi : IApi
    {
        public IApi Api { get; set; }

        public CompositeApi() {}

        public CompositeApi(IApi api)
        {
            Api = api;
        }

        public IBanking Banking { get => Api.Banking; set => Api.Banking = value; }
        public IBot Bot { get => Api.Bot; set => Api.Bot = value; }
        public IBotResources BotResources { get => Api.BotResources; set => Api.BotResources = value; }
        public ICharacterInfoWindow CharacterInfoWindow { get => Api.CharacterInfoWindow; set => Api.CharacterInfoWindow = value; }
        public ICharacterSelectWindow CharacterSelectWindow { get => Api.CharacterSelectWindow; set => Api.CharacterSelectWindow = value; }
        public IChat Chat { get => Api.Chat; set => Api.Chat = value; }
        public ICodecs Codecs { get => Api.Codecs; set => Api.Codecs = value; }
        public ICollision Collision { get => Api.Collision; set => Api.Collision = value; }
        public ICraftingWindow CraftingWindow { get => Api.CraftingWindow; set => Api.CraftingWindow = value; }
        public IEntities Entities { get => Api.Entities; set => Api.Entities = value; }
        public IEquipment Equipment { get => Api.Equipment; set => Api.Equipment = value; }
        public IExpeditionHud ExpeditionHud { get => Api.ExpeditionHud; set => Api.ExpeditionHud = value; }
        public IExpeditionWindow ExpeditionWindow { get => Api.ExpeditionWindow; set => Api.ExpeditionWindow = value; }
        public IFactories Factories { get => Api.Factories; set => Api.Factories = value; }
        public IFarmableWindow FarmableWindow { get => Api.FarmableWindow; set => Api.FarmableWindow = value; }
        public IFastTravelWindow FastTravelWindow { get => Api.FastTravelWindow; set => Api.FastTravelWindow = value; }
        public IFiles Files { get => Api.Files; set => Api.Files = value; }
        public IGame Game { get => Api.Game; set => Api.Game = value; }
        public IGeometryUtils GeometryUtils { get => Api.GeometryUtils; set => Api.GeometryUtils = value; }
        public IGoldMarketWindow GoldMarketWindow { get => Api.GoldMarketWindow; set => Api.GoldMarketWindow = value; }
        public IGraphs Graphs { get => Api.Graphs; set => Api.Graphs = value; }
        public IHotkeys Hotkeys { get => Api.Hotkeys; set => Api.Hotkeys = value; }
        public IInput Input { get => Api.Input; set => Api.Input = value; }
        public IInventory Inventory { get => Api.Inventory; set => Api.Inventory = value; }
        public ILogging Logging { get => Api.Logging; set => Api.Logging = value; }
        public ILoginErrorWindow LoginErrorWindow { get => Api.LoginErrorWindow; set => Api.LoginErrorWindow = value; }
        public ILoginWindow LoginWindow { get => Api.LoginWindow; set => Api.LoginWindow = value; }
        public IMarket Market { get => Api.Market; set => Api.Market = value; }
        public IMovement Movement { get => Api.Movement; set => Api.Movement = value; }
        public INet Net { get => Api.Net; set => Api.Net = value; }
        public IObjects Objects { get => Api.Objects; set => Api.Objects = value; }
        public IPaySilverWindow PaySilverWindow { get => Api.PaySilverWindow; set => Api.PaySilverWindow = value; }
        public IPlayers Players { get => Api.Players; set => Api.Players = value; }
        public IRendering Rendering { get => Api.Rendering; set => Api.Rendering = value; }
        public IRepairWindow RepairWindow { get => Api.RepairWindow; set => Api.RepairWindow = value; }
        public IResourceRepository ResourceRepository { get => Api.ResourceRepository; set => Api.ResourceRepository = value; }
        public ISerialization Serialization { get => Api.Serialization; set => Api.Serialization = value; }
        public IUI UI { get => Api.UI; set => Api.UI = value; }
        public IViews Views { get => Api.Views; set => Api.Views = value; }
        public IGuiScene GuiScene { get => Api.GuiScene; set => Api.GuiScene = value; }
        public IScriptLoader ScriptLoader { get => Api.ScriptLoader; set => Api.ScriptLoader = value; }
        public IScriptEngine ScriptEngine { get => Api.ScriptEngine; set => Api.ScriptEngine = value; }
    }
}
