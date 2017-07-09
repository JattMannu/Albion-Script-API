using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Gui
{
    public interface ISlider : IComponent
    {
        /// <summary>
        /// Changes the minimum value of this slider.
        /// </summary>
        /// <param name="min">The new minimum value.</param>
        void SetMinValue(float min);

        /// <summary>
        /// Changes the maximum value of this slider.
        /// </summary>
        /// <param name="max">The new maximum value.</param>
        void SetMaxValue(float max);
    }
}
