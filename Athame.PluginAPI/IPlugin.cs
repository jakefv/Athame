﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athame.PluginAPI
{
    public interface IPlugin
    {
        string GetName();
        string GetDescription();
    }
}
