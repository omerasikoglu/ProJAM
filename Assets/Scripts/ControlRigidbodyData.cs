using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM
{
    public class ControlRigidbodyData : MonoBehaviour
    {
        [SerializeField] private Vector3 _jumpForce;

        
        public Vector3 JumpForce { get; private set; }
    }
}
