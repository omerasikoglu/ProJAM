using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Data/Beat")]
    public class BeatManagerData : ScriptableObject
    {
        [SerializeField] private float _BPM;
        [SerializeField] private float _beatTimer;
        public float BPM { get { return _BPM; } }
        public float BeatTimer { get { return _beatTimer; } }
    }
}
