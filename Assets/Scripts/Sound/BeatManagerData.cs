using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Sound/Data/Beat")]
    public class BeatManagerData : ScriptableObject
    {

        [Header("[Spectate]")]
        public bool isBeatFull; //static
        public bool isBeatD8; //static

        public int beatCountFull; //static
        public int beatCountD8; //static

        public float beatTimer;
        public float beatTimerD8;

        public float beatInterval;
        public float beatIntervalD8;



    }
}
