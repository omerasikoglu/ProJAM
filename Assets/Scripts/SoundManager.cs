using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    public class SoundManager : MonoBehaviour
    {
        [SerializeField] private List<Sound> _soundList;


        private Dictionary<Sound, float> _soundTimerDictionary;

        private void Awake()
        {
            Init();
        }
        private void Init()
        {
            _soundTimerDictionary = new Dictionary<Sound, float>();

            foreach (Sound sound in _soundList)
            {
                _soundTimerDictionary.Add(sound, sound.SoundTimer);
            }
        }
    } 
}
