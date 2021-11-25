using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.PlayerInput
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Input/Data")]
    public class InputReceiverData : ScriptableObject
    {
        public Vector3 mousePosition;

        public float horizontalInput;
        public float verticalInput;
        public float mouseInputX;
        public float mouseInputY;

        public bool isAttacking;
        public bool isJumping;
        public bool isHolding;
        public bool isDashing;
        public bool isBlocking;
        public bool isPressWeapon1Button;
        public bool isPressWeapon2Button;
        public bool isScrollingDown;
        public bool isScrollingUp;
        public bool isPressOpenMapButton;
        public bool isPressSpecialPowerButton;
        public bool isClickLeftMouseButton;
        public bool isClickRightMouseButton;
        public bool isReloading;


    }
}
