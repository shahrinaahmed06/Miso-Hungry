using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tests
{
    public class MuteManager : MonoBehaviour
    {
        private bool isMuted;
        
        void Start()
        {
            isMuted = false;
        }

        public void mutePressed()
        {
            isMuted = !isMuted;
            AudioListener.pause = isMuted;
        }
    }
}
