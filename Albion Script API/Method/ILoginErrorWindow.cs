using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Method
{
    /// <summary>
    /// Provides a set of utilities for interacting with the interface that's shown
    /// when a failed login happens.
    /// </summary>
    public interface ILoginErrorWindow : IApiModule
    {
        /// <summary>
        /// If this window is open.
        /// </summary>
        bool IsOpen { get; }

        /// <summary>
        /// The error message being shown.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Attempts to click the ok button, causing the screen to close.
        /// </summary>
        void ClickOk();
    }
}
