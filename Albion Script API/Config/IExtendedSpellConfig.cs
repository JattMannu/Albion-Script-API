namespace Ennui.Api.Xml
{
    /// <summary>
    /// Contains extended configuration information about a spell.
    /// </summary>
    public interface IExtendedSpellConfig : ISpellConfig
    {
        /// <summary>
        /// The casting time of the spell.
        /// </summary>
        INanoTime CastingTime { get; }

        /// <summary>
        /// The recast delay on the spell.
        /// </summary>
        INanoTime RecastDelay { get; }

        /// <summary>
        /// The maximum cast range of the spell.
        /// </summary>
        float CastRange { get; }
        
        /// <summary>
        /// If this spell can be casted when the entity is silenced.
        /// </summary>
        bool CastableWhenSilenced { get; }

        /// <summary>
        /// If line of sight is required to cast this spell.
        /// </summary>
        bool RequiredLos { get; }
    }
}
