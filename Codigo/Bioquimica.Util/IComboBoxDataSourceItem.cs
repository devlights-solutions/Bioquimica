﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public interface IComboBoxDataSourceItem
    {
        int GetValue();
        string GetText();
    }
}
