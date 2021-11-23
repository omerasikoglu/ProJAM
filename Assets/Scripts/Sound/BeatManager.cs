using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    public class BeatManager : MonoBehaviour
    {
        [SerializeField] private BeatManagerData _beatData;

        private void Awake()
        {
            Init();
        }
        private void Update()
        {
            BeatDetection();
        }

        private void Init()
        {
            _beatData.beatCountFull = 0;
            _beatData.beatCountD8 = 0;
            _beatData.beatTimer = 0f;
            _beatData.beatTimerD8 = 0f;
            _beatData.beatInterval = 0f;
            _beatData.beatIntervalD8 = 0f;
        }

        private void BeatDetection()
        {
            //full beat count
            _beatData.isBeatFull = false;
            _beatData.beatInterval = 60 / _beatData.BPM;
            _beatData.beatTimer += Time.deltaTime;

            if (_beatData.beatTimer >= _beatData.beatInterval)
            {
                _beatData.beatTimer -= _beatData.beatInterval;
                _beatData.isBeatFull = true;
                _beatData.beatCountFull++;
                Debug.Log("Full");
            }

            //divided beat count
            _beatData.isBeatD8 = false;
            _beatData.beatIntervalD8 = _beatData.beatInterval / 8;
            _beatData.beatTimerD8 += Time.deltaTime;
            if (_beatData.beatTimerD8 >= _beatData.beatIntervalD8)
            {
                _beatData.beatTimerD8 -= _beatData.beatIntervalD8;
                _beatData.isBeatD8 = true;
                _beatData.beatCountD8++;
                Debug.Log("D8");
            }

        }




    }

}