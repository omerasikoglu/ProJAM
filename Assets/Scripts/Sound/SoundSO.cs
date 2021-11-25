using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Sound/SoundSO", order = -2)]
    public class SoundSO : ScriptableObject
    {
        [SerializeField] private string _soundName;
        [SerializeField] private AudioClip _soundAudioClip;
        [SerializeField] private float _soundVolume;
        [SerializeField] private float _soundTimer;

        public string SoundName { get { return _soundName; } }
        public AudioClip SoundAudioClip { get { return _soundAudioClip; } }
        public float SoundVolume { get { return _soundVolume; } }
        public float SoundTimer { get { return _soundTimer; } }
    }

}