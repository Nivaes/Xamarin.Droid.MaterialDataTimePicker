﻿namespace AndroidX.AppCompat.View.Menu
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class ListMenuItemView
    {
        void IMenuViewItemView.SetEnabled(bool enable)
        {
            Enabled = enable;
        }
    }
}
