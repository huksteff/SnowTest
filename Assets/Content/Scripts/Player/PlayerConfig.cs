﻿using UnityEditor;
using UnityEngine;

namespace DefaultNamespace.Player
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "ScriptableObjects/New PlayerConfig", order = 51)]
    public class PlayerConfig : ScriptableObject
    {
        public float PlayerMovementSpeed = 5f;
        public float PlayerRotationSpeed = 40f;
    }
}