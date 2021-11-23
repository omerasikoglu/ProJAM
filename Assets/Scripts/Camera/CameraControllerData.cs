using UnityEngine;

namespace ProJAM.Camera
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Data/Camera")]
    public class CameraControllerData : ScriptableObject
    {

        [SerializeField] private float _rotationLerpSpeed;
        [SerializeField] private float _positionLerpSpeed;

        [SerializeField] private Vector3 _positionOffset;

        public float RotationLerpSpeed { get { return _rotationLerpSpeed; } }
        public float PositionLerpSpeed { get { return _positionLerpSpeed; } }
        public Vector3 PositionOffset { get { return _positionOffset; } }
    }
}
