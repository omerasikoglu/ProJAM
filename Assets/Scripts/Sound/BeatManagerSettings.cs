using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Sound/Settings/Beat")]
    public class BeatManagerSettings : ScriptableObject
    {
        [SerializeField] private float _BPM;
        public float BPM { get { return _BPM; } }
    }
}
