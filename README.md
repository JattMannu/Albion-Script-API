# Albion-Script-API
An interface that allows you to write scripts for Ennui's Albion Online bot

# Script Skeleton
```C#
using Ennui.Api;
using Ennui.Api.Method;
using Ennui.Api.Script;

namespace Ennui.Script.Official
{
    [LocalScript]
    public class ExampleScript : AbstractScript
    {
        public override int OnLoop(IScriptEngine se)
        { 
            var config = new PointPathFindConfig();
            config.UseWeb = false;
            config.UseMount = true;
            config.ClusterName = "Smoothfloor Cleft";
            config.Point = new Vector3f(338.72f, -0.18f, 1.91f);

            if (Movement.PathFindTo(config) != PathFindResult.Success)
            {
                Logging.Log("Failed to find path!");
            }

            return 1000;
        }
    }
}
```
