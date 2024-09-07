using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace.Player
{
    public class PlayerView : MonoBehaviour
    {
        public Animator Animator;
        public float MovementSpeed = 5f;
        public float RotationSpeed = 40f;
        public float MoveSmoothTime = 2f;
    }
}