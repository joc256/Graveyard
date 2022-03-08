﻿using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Hearthstone;
using System;
using System.Collections.Generic;

namespace HDT.Plugins.Graveyard
{
    internal class ViewConfig
    {
        public string Name { get; set; }
        public Func<bool> Enabled { get; set; }
        public Func<bool> ShowFirst { get; set; } = () => false;
        public ActionList<Card> UpdateOn { get; set; }       
        public List<string> ShowOn { get; set; }
        public Predicate<Card> Condition { get; set; }        
        public Func<ViewBase> CreateView { get; set; }

        public ViewConfig() { }
        public ViewConfig(params string[] showOn)
        {
            ShowOn = new List<string>(showOn);
        }
    }
}
