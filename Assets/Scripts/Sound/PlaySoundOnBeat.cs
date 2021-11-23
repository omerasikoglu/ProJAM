using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    public class PlaySoundOnBeat : MonoBehaviour
    {
        [SerializeField] private BeatManagerData _beatData;
        [SerializeField] private SoundManager _soundManager;

        [SerializeField] private SoundPackageData _soundPackageData;

        private int _randomStrum;

        private List<Sound> _soundList;
        private Dictionary<Sound, float> _soundTimerDictionary;
        private void Init()
        {
            _soundTimerDictionary = new Dictionary<Sound, float>();

            foreach (Sound sound in _soundList)
            {
                _soundTimerDictionary.Add(sound, sound.SoundTimer);
            }
        }
        private void Update()
        {
            if (_beatData.isBeatFull)
            {
                _soundManager.PlaySound(_soundPackageData.Tap.SoundAudioClip, _soundPackageData.Tap.SoundVolume);   //0.5f
                if (_beatData.beatCountFull % 2 == 0)
                {
                    _randomStrum = UnityEngine.Random.Range(0, _soundPackageData.StrumList.Count);
                }
            }

            if (_beatData.isBeatD8 && _beatData.beatCountD8 % 2 == 0)
            {
                _soundManager.PlaySound(_soundPackageData.Tick.SoundAudioClip, _soundPackageData.Tick.SoundVolume); //0.1f
            }
            if (_beatData.isBeatD8 && (_beatData.beatCountD8 % 8 == 2 || _beatData.beatCountD8 % 8 == 4))
            {
                _soundManager.PlaySound(_soundPackageData.StrumList[_randomStrum].SoundAudioClip, _soundPackageData.StrumList[_randomStrum].SoundVolume);
            }

        }
    }
}
