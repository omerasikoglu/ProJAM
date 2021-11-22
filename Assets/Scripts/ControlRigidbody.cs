using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM
{
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private ControlRigidbodyData _data;
        [SerializeField] private Rigidbody2D _rigidbody;
    }

}