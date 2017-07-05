using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Script
{
    /// <summary>
	/// Represents a script implementation that has individual, clearly defined states.
	/// </summary>
	public class StateScript : AbstractStateScript
    {
        /// <summary>
        /// Allows us to hook into the loop execution of this script.
        /// </summary>
        /// <returns>If the loop method should return early</returns>
        public delegate bool GlobalHook();

        private IScriptEngine scriptEngine;

        /// <summary>
        /// The StateScript that this script is registered to, or null if this script is the root script.
        /// </summary>
        protected StateScript parent;

        /// <summary>
        /// A list of states registered to this script that we can switch between with keys.
        /// </summary>
        protected Dictionary<string, StateScript> states = new Dictionary<string, StateScript>();

        private string currentKey = string.Empty;
        private StateScript current;
        private List<GlobalHook> hooks = new List<GlobalHook>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StateScript"/> class.
        /// </summary>
        public StateScript(IApi api, IScriptEngine se) : base(api)
        {
            this.scriptEngine = se;
        }

        public StateScript(IScriptEngine se) : base(null)
        {
            this.scriptEngine = se;
        }

        /// <summary>
        /// Retrieves this script's parent.
        /// </summary>
        /// <returns>The parent of this script.</returns>
        /// <typeparam name="T">The parent's type.</typeparam>
        public T GetParent<T>() where T : StateScript
        {
            return (T)parent;
        }

        /// <summary>
        /// Adds a new state to switch between.
        /// </summary>
        /// <param name="key">The key that can be used to switch to the new state.</param>
        /// <param name="script">The script belonging to the state.</param>
        public void AddState(string key, StateScript script)
        {
            script.parent = this;
            states.Add(key, script);
        }

        /// <summary>
        /// Registers a new hook.
        /// </summary>
        /// <param name="hook">The hook to register.</param>
        public void AddHook(GlobalHook hook)
        {
            this.hooks.Add(hook);
        }

        /// <summary>
        /// Switches to a different state, and handles the killing
        /// of the currently running state.
        /// </summary>
        /// <param name="key">The key of the state to enter.</param>
        public override void EnterState(string key)
        {
            StateScript script;
            if (key != null && states.TryGetValue(key, out script))
            {
                var tmp = current;
                if (tmp != null)
                {
                    tmp.OnStop(scriptEngine);
                }

                if (script.OnStart(scriptEngine))
                {
                    currentKey = key;
                    current = script;
                }
            }
            else
            {
                var tmp = current;
                if (tmp != null)
                {
                    tmp.OnStop(scriptEngine);
                }

                currentKey = null;
                current = null;
            }
        }

        /// <summary>
        /// Switches to a different state, and handles the killing
        /// of the currently running state.
        /// </summary>
        /// <param name="script">The state to enter.</param>
        public override void EnterState(StateScript script)
        {
            var tmp = current;
            if (tmp != null)
            {
                tmp.OnStop(scriptEngine);
            }

            script.parent = this;
            if (script.OnStart(scriptEngine))
            {
                currentKey = string.Empty;
                current = script;
            }
        }

        /// <summary>
        /// Retrieves the state child that this state is currently running.
        /// </summary>
        /// <value>The state child that this state is currently running.</value>
        public StateScript Running
        {
            get { return current; }
        }

        /// <summary>
        /// Retrieves the key of the state child that this state is currently running.
        /// </summary>
        /// <value>The key of the state child that this state is currently running.</value>
        public string RunningKey
        {
            get { return currentKey; }
        }

        /// <inheritdoc/>
        public override bool OnStart(IScriptEngine se)
        {
            return true;
        }

        /// <inheritdoc/>
        public override int OnLoop(IScriptEngine se)
        {
            foreach (var hook in hooks)
            {
                if (hook())
                {
                    Api.Logging.Log("[StateScript#OnLoop] Hooked");
                    return 100;
                }
            }

            var tmp = current;
            if (tmp != null)
            {
                return tmp.OnLoop(scriptEngine);
            }
            return 1000;
        }

        /// <inheritdoc/>
        public override void OnStop(IScriptEngine se)
        {

        }

        /// <inheritdoc/>
        public override void OnPaint(IScriptEngine se, GraphicContext g)
        {
            var tmp = current;
            if (tmp != null)
            {
                tmp.OnPaint(scriptEngine, g);
            }
        }
    }
}
