namespace Ennui.Api
{
    public interface ICastSpellEventHandler
    {
        bool ReadyToCast(byte index);
    }
}
