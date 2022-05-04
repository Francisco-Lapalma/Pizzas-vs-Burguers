using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] public float playerSpeed = 3f;
    [SerializeField] public float playerGravity = 3f;
}
