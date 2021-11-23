using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    public class SoundManager : MonoBehaviour
    {
        [SerializeField] private int poolSize = 10;
        private List<AudioSource> _soundClipPool;

        private void Awake()
        {
            _soundClipPool = new List<AudioSource>();
            for (int i = 0; i < poolSize; i++)
            {
                GameObject go = CreateGO();
                _soundClipPool.Add(go.GetComponent<AudioSource>());
            }
        }

        public void PlaySound(AudioClip clip, float volume)
        {
            //pool'da çalmayan bi tanesini bulur ve verilerini deðiþtirir; bulamazsa yeni GO oluþturur
            for (int i = 0; i < _soundClipPool.Count; i++)
            {
                if (!_soundClipPool[i].isPlaying)
                {
                    _soundClipPool[i].clip = clip;
                    _soundClipPool[i].volume = volume;
                    _soundClipPool[i].Play();
                    return;
                }
            }

            GameObject go = CreateGO();
            go.GetComponent<AudioSource>().clip = clip;
            go.GetComponent<AudioSource>().volume = volume;
            go.GetComponent<AudioSource>().Play();
            _soundClipPool.Add(go.GetComponent<AudioSource>());

        }

        private GameObject CreateGO()
        {
            GameObject go = new GameObject("soundClip");
            go.AddComponent<AudioSource>();
            go.transform.parent = this.transform;
            return go;
        }

    }
}
