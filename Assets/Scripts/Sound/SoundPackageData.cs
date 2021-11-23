using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.Sound
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Data/SoundPackage")]
    public class SoundPackageData : ScriptableObject
    {
        [SerializeField] private Sound _tap;      //1 defa çalarken
        [SerializeField] private Sound _tick;     //8 defa çalar
        [SerializeField] private List<Sound> _strumList;  //süslemeler

        public Sound Tap { get { return _tap; } }
        public Sound Tick { get { return _tick; } }
        public List<Sound> StrumList { get { return _strumList; } }




    }

}