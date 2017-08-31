using Ennui.Api.Meta;
namespace Ennui.Api.Xml
{
    public interface IXmlSpellConfig : IXmlUiSpellConfig
    {
        /// <summary>
        /// The type that this spell can target.
        /// </summary>
        SpellTarget Target { get; }

        /// <summary>
        /// The category that the spell is in.
        /// </summary>
        SpellCategory Category { get; }

        /// <summary>
        /// The maximum amount of times that this spell can be stacked.
        /// </summary>
        int MaxStack { get; }

        /// <summary>
        /// The amount of energy required to cast this spell.
        /// </summary>
        int EnergyCost { get; }

        /// <summary>
        /// The assessment of the spell.
        /// </summary>
        SpellAssessment Assessment { get; }
    }
}
