using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProJAM.PlayerInput;

namespace ProJAM.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private PlayerMovementData _movementData;
        [SerializeField] private InputReceiverData _inputData;
        [SerializeField] private Rigidbody2D _rigidbody;

        private void Update()
        {
            //_rigidbody.MovePosition(_rigidbody.position + new Vector2(_inputData.horizontalInput , _inputData.verticalInput) * Time.deltaTime * _movementData.MovementSpeed);
            
        }
        private void FixedUpdate()
        {
            _rigidbody.velocity = new Vector2(_movementData.MovementSpeed * _inputData.horizontalInput, _inputData.verticalInput) * _movementData.MovementSpeed;
        }
    }
}
