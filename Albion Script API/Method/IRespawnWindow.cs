namespace Ennui.Api.Method
{
    public interface IRespawnWindow : IWidget
    {
        void RespawnAtExpeditionStart();

        void RespawnAtHome();

        void RespawnInThisArea();

        void RespawnAtClosestCity();

        void RespawnAtClosestGuildTerritory();
    }
}
