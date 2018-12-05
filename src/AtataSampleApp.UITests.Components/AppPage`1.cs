﻿using Atata;

namespace AtataSampleApp.UITests
{
    public abstract class AppPage<TOwner> : Page<TOwner>
        where TOwner : AppPage<TOwner>
    {
        public MainMenu<TOwner> Menu { get; private set; }
    }
}
