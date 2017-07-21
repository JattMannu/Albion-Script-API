using Ennui.Api.Direct.Xml;

namespace Ennui.Api.Direct.Object
{
    /// <summary>
    /// Represents a spell area indicator within the scene.
    /// </summary>
    public interface ISpellEffectAreaObject : ISimulationObject
    {
        IXmlSpellConfig GetSpellXmlConfig();
    }
}