using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.PlayerInput
{
    public class InputReceiver : MonoBehaviour
    {
        [SerializeField] private InputReceiverData _inputData;
        [Space(20)] [SerializeField] private KeyCode attackButton;
        [SerializeField] private KeyCode jumpButton;
        [SerializeField] private KeyCode holdButton;
        [SerializeField] private KeyCode dashButton;
        [SerializeField] private KeyCode blockButton;
        [SerializeField] private KeyCode weapon1Button;
        [SerializeField] private KeyCode weapon2Button;
        [SerializeField] private KeyCode mapButton;
        [SerializeField] private KeyCode specialPowerButton;
        [SerializeField] private KeyCode reloadButton;

        private const string HORIZONTAL = "Horizontal";
        private const string VERTICAL = "Vertical";
        private const string MOUSE_X = "Mouse X";
        private const string MOUSE_Y = "Mouse Y";

        private void Update()
        {
            ReceiveAxisInput();
            ReceiveButtonsInput();
            ReceiveMouseInput();
        }

        private void ReceiveMouseInput()
        {
            _inputData.mousePosition = Input.mousePosition;
        }

        private void ReceiveAxisInput()
        {
            _inputData.horizontalInput = Input.GetAxis(HORIZONTAL);
            _inputData.verticalInput = Input.GetAxis(VERTICAL);
            _inputData.mouseInputX = Input.GetAxis(MOUSE_X);
            _inputData.mouseInputY = Input.GetAxis(MOUSE_Y);
        }
        private void ReceiveButtonsInput()
        {
            _inputData.isAttacking = Input.GetKeyDown(attackButton);
            _inputData.isJumping = Input.GetKeyDown(jumpButton);
            _inputData.isHolding = Input.GetKey(holdButton);
            _inputData.isDashing = Input.GetKeyDown(dashButton);
            _inputData.isBlocking = Input.GetKey(blockButton);
            _inputData.isPressWeapon1Button = Input.GetKeyDown(weapon1Button);
            _inputData.isPressWeapon2Button = Input.GetKeyDown(weapon2Button);
            _inputData.isScrollingDown = Input.mouseScrollDelta.y < 0;
            _inputData.isScrollingUp = Input.mouseScrollDelta.y > 0;
            _inputData.isPressOpenMapButton = Input.GetKeyDown(mapButton);
            _inputData.isPressSpecialPowerButton = Input.GetKeyDown(specialPowerButton);
            _inputData.isClickLeftMouseButton = Input.GetMouseButtonDown(0);
            _inputData.isClickRightMouseButton = Input.GetMouseButtonDown(1);
            _inputData.isReloading = Input.GetKeyDown(reloadButton);

        }
    }
}
