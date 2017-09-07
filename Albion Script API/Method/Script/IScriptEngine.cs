namespace Ennui.Api.Script
{
    /// <summary>
    /// Represents something that handles the execution of scripts.
    /// <see cref="AbstractScript"/>.
    /// </summary>
    public interface IScriptEngine
    {
        /// <summary>
        /// The API that will be provided to scripts.
        /// </summary>
        IApi Api { get; set; }

        /// <summary>
        /// Runs the provided script.
        /// </summary>
        /// <param name="script">The script to run.</param>
        void RunScript(AbstractScript script);

        /// <summary>
        /// Stops the currently running script.
        /// </summary>
        void StopScript();

        /// <summary>
        /// Pauses the currently running script.
        /// </summary>
        void PauseScript();

        /// <summary>
        /// Resumes teh currently running script.
        /// </summary>
        void ResumeScript();
    }
}
