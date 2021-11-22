using UnityEngine;

namespace ProJAM.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraControllerData _cameraData;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private Transform _cameraTransform;

        private void Update()
        {
            //CameraRotationFollow();
            CameraPositionFollow();
        }

        private void CameraRotationFollow()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation,
                Quaternion.LookRotation(_targetTransform.position - _cameraTransform.position),
                Time.deltaTime * _cameraData.RotationLerpSpeed);
        }
        private void CameraPositionFollow()
        {
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position,
                _targetTransform.position + _cameraData.PositionOffset, Time.deltaTime * _cameraData.PositionLerpSpeed);
        }
    }
}