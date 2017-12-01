using Ennui.Api.Gui;
using Ennui.Api.Method;
using Ennui.Api.Script;

namespace Ennui.Api
{
    /// <summary>
    /// An API implementation that delegates to another API.
    /// </summary>
    public class CompositeApi : IApi
    {
        /// <summary>
        /// The API to delegate to.
        /// </summary>
        public IApi Api { get; set; }

        /// <summary>
        /// Creates a new composite API that has no functionality.
        /// </summary>
        public CompositeApi() { }

        /// <summary>
        /// Creates a new composite API that delegates to the provided API.
        /// </summary>
        /// <param name="api"></param>
        public CompositeApi(IApi api)
        {
            Api = api;
        }

        public IBanking Banking { get { return Api.Banking; } set { Api.Banking = value; } }
        public IBot Bot { get { return Api.Bot; } set { Api.Bot = value; } }
        public IBotResources BotResources { get { return Api.BotResources; } set { Api.BotResources = value; } }
        public ICharacterInfoWindow CharacterInfoWindow { get { return Api.CharacterInfoWindow; } set { Api.CharacterInfoWindow = value; } }
        public ICharacterSelectWindow CharacterSelectWindow { get { return Api.CharacterSelectWindow; } set { Api.CharacterSelectWindow = value; } }
        public IChat Chat { get { return Api.Chat; } set { Api.Chat = value; } }
        public ICodecs Codecs { get { return Api.Codecs; } set { Api.Codecs = value; } }
        public ICollision Collision { get { return Api.Collision; } set { Api.Collision = value; } }
        public ICraftingWindow CraftingWindow { get { return Api.CraftingWindow; } set { Api.CraftingWindow = value; } }
        public IEntities Entities { get { return Api.Entities; } set { Api.Entities = value; } }
        public IEquipment Equipment { get { return Api.Equipment; } set { Api.Equipment = value; } }
        public IExpeditionHud ExpeditionHud { get { return Api.ExpeditionHud; } set { Api.ExpeditionHud = value; } }
        public IExpeditionWindow ExpeditionWindow { get { return Api.ExpeditionWindow; } set { Api.ExpeditionWindow = value; } }
        public IFactories Factories { get { return Api.Factories; } set { Api.Factories = value; } }
        public IFarmableWindow FarmableWindow { get { return Api.FarmableWindow; } set { Api.FarmableWindow = value; } }
        public IFastTravelWindow FastTravelWindow { get { return Api.FastTravelWindow; } set { Api.FastTravelWindow = value; } }
        public IFiles Files { get { return Api.Files; } set { Api.Files = value; } }
        public IGame Game { get { return Api.Game; } set { Api.Game = value; } }
        public IGeometryUtils GeometryUtils { get { return Api.GeometryUtils; } set { Api.GeometryUtils = value; } }
        public IGoldMarketWindow GoldMarketWindow { get { return Api.GoldMarketWindow; } set { Api.GoldMarketWindow = value; } }
        public IGraphs Graphs { get { return Api.Graphs; } set { Api.Graphs = value; } }
        public IHotkeys Hotkeys { get { return Api.Hotkeys; } set { Api.Hotkeys = value; } }
        public IInput Input { get { return Api.Input; } set { Api.Input = value; } }
        public IInventory Inventory { get { return Api.Inventory; } set { Api.Inventory = value; } }
        public ILogging Logging { get { return Api.Logging; } set { Api.Logging = value; } }
        public ILoginErrorWindow LoginErrorWindow { get { return Api.LoginErrorWindow; } set { Api.LoginErrorWindow = value; } }
        public ILoginWindow LoginWindow { get { return Api.LoginWindow; } set { Api.LoginWindow = value; } }
        public IMarket Market { get { return Api.Market; } set { Api.Market = value; } }
        public IMovement Movement { get { return Api.Movement; } set { Api.Movement = value; } }
        public INet Net { get { return Api.Net; } set { Api.Net = value; } }
        public IObjects Objects { get { return Api.Objects; } set { Api.Objects = value; } }
        public IPaySilverWindow PaySilverWindow { get { return Api.PaySilverWindow; } set { Api.PaySilverWindow = value; } }
        public IPlayers Players { get { return Api.Players; } set { Api.Players = value; } }
        public IRendering Rendering { get { return Api.Rendering; } set { Api.Rendering = value; } }
        public IRepairWindow RepairWindow { get { return Api.RepairWindow; } set { Api.RepairWindow = value; } }
        public IResourceRepository ResourceRepository { get { return Api.ResourceRepository; } set { Api.ResourceRepository = value; } }
        public IRespawnWindow RespawnWindow { get { return Api.RespawnWindow; } set { Api.RespawnWindow = value; } }
        public ISerialization Serialization { get { return Api.Serialization; } set { Api.Serialization = value; } }
        public IGuiScene GuiScene { get { return Api.GuiScene; } set { Api.GuiScene = value; } }
        public IScriptLoader ScriptLoader { get { return Api.ScriptLoader; } set { Api.ScriptLoader = value; } }
        public IScriptEngine ScriptEngine { get { return Api.ScriptEngine; } set { Api.ScriptEngine = value; } }
    }
}
