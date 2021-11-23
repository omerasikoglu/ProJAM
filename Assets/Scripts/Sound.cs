using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Sound")]
    public class Sound : ScriptableObject
    {
        [SerializeField] private string _soundName;
        [SerializeField] private AudioClip _soundAudioClip;
        [SerializeField] private float _soundTimer;

        public string SoundName { get { return _soundName; } }
        public AudioClip SoundAudioClip { get { return _soundAudioClip; } }
        public float SoundTimer { get { return _soundTimer; } }
    }

}