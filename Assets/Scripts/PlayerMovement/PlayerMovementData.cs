using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProJAM.PlayerMovement
{
    [CreateAssetMenu(menuName = "Scriptable Objects/Data/Movement")]
    public class PlayerMovementData : ScriptableObject
    {
        [SerializeField] private float _movementSpeed;
        public float MovementSpeed { get { return _movementSpeed; } }
    }

}