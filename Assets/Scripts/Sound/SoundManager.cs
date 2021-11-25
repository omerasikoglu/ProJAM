using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    // PlaySoundOnBeat Manager
    public class SoundManager : MonoBehaviour
    {
        [SerializeField] private SoundPool _soundPool;
        [Space(20)] [SerializeField] private BeatManagerData _beatData;
        [SerializeField] private SoundListSO _soundList;

        private int _randomStrum;

        //private List<SoundSO> soundList;
        //private Dictionary<SoundSO, float> _soundTimerDictionary;
        //private void Init()
        //{
        //    _soundTimerDictionary = new Dictionary<SoundSO, float>();

        //    foreach (SoundSO sound in _soundList)
        //    {
        //        _soundTimerDictionary.Add(sound, sound.SoundTimer);
        //    }
        //}
        private void Update()
        {
            if (_beatData.isBeatFull)
            {
                _soundPool.PlaySound(_soundList.Tap.SoundAudioClip, _soundList.Tap.SoundVolume);   //0.5f
                if (_beatData.beatCountFull % 2 == 0)
                {
                    _randomStrum = UnityEngine.Random.Range(0, _soundList.StrumList.Count);
                }
            }

            if (_beatData.isBeatD8 && _beatData.beatCountD8 % 2 == 0)
            {
                _soundPool.PlaySound(_soundList.Tick.SoundAudioClip, _soundList.Tick.SoundVolume); //0.1f
            }
            if (_beatData.isBeatD8 && (_beatData.beatCountD8 % 8 == 2 || _beatData.beatCountD8 % 8 == 4))
            {
                if (_soundList.StrumList[_randomStrum] != null)
                {
                    _soundPool.PlaySound(_soundList.StrumList[_randomStrum].SoundAudioClip, _soundList.StrumList[_randomStrum].SoundVolume);
                }
            }

        }
    }
}
