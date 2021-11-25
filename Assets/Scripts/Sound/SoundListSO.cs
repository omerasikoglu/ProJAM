using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Sound/SoundPackageSO", order = -1)]
    public class SoundListSO : ScriptableObject
    {
        [SerializeField] private SoundSO _tap;      //1 defa çalarken
        [SerializeField] private SoundSO _tick;     //8 defa çalar
        [SerializeField] private List<SoundSO> _strumList;  //süslemeler

        public SoundSO Tap { get { return _tap; } }
        public SoundSO Tick { get { return _tick; } }
        public List<SoundSO> StrumList { get { return _strumList; } }




    }

}