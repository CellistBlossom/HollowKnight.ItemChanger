﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemChanger.Locations;
using ItemChanger.Util;
using ItemChanger.Extensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ItemChanger.Placements
{
    /// <summary>
    /// Placement for self-implementing locations, usually acting through cutscene or conversation fsms.
    /// </summary>
    public class AutoPlacement : AbstractPlacement, IPrimaryLocationPlacement
    {
        public AutoPlacement(string Name) : base(Name) { }

        public AutoLocation Location;

        AbstractLocation IPrimaryLocationPlacement.Location => Location;

        protected override void OnLoad()
        {
            Location.Placement = this;
            Location.Load();
        }

        protected override void OnUnload()
        {
            Location.Unload();
        }

    }
}