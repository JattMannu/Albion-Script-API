using System;

namespace Ennui.Api.Example
{
    public class ExpeditionsExample : ApiResource
    {
        public ExpeditionsExample(IApi api) : base(api)
        {
        }

        public void EnterExpedition(int tier)
        {
            if (ExpeditionWindow.IsOpen)
            {
                var target = ExpeditionWindow.ExpeditionConfigs.Find(e => (e.Tier == tier));
                if (target == null)
                {
                    throw new InvalidOperationException("No expedition found with tier!");
                }
                ExpeditionWindow.Enter(target);
            }
        }
    }
}
