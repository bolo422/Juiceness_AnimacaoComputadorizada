using System;
using UnityEngine;

    public abstract class Selected : MonoBehaviour
    {
        protected bool hover = false;

        protected abstract void ChangeMateral(Renderer mr, Material mat);
        public abstract void HoverSwitch();
        
        public abstract void HoverSwitch(bool newValue);

        protected void CheckForRelevantAnimation()
        {
            if (AnimationWatcher.Instance.isRelevantAnimationPlaying) hover = false;
        }
    }
