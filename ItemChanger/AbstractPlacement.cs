﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ItemChanger
{
    public abstract class AbstractPlacement
    {
        public string name;
        public abstract string SceneName { get; }
        public List<AbstractItem> items = new List<AbstractItem>();
        public bool visited;

        public virtual void OnEnableFsm(PlayMakerFSM fsm)
        {

        }

        public virtual void OnActiveSceneChanged()
        {

        }

        /// <summary>
        /// Override for custom text with sheetName "ItemChanger.Locations". Applies first non-null return value.
        /// </summary>
        public virtual string OnLanguageGet(string convoName)
        {
            return null;
        }

        /// <summary>
        /// Called on each location when the location list is first read. Dispose hooks in OnUnHook.
        /// </summary>
        public virtual void OnHook()
        {

        }

        public virtual void OnUnHook()
        {

        }

        public bool HasVisited() => visited;

        public virtual void AddItem(AbstractItem item) => items.Add(item);
    }
}