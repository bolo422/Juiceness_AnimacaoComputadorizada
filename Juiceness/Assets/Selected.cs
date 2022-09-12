using UnityEngine;

    public abstract class Selected : MonoBehaviour
    {
        protected abstract void ChangeMateral(Renderer mr, Material mat);
        public abstract void HoverSwitch();
        
        public abstract void HoverSwitch(bool newValue);
    }
