﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ennui.Api.Direct.View
{
    public interface IWorldObjectView : ISimulationObjectView
    {
        bool Click(string collider);

        bool Click();
    }
}