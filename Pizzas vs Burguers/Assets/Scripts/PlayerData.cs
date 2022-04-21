using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] protected float playerSpeed = 3f;
    [SerializeField] protected float playerGravity = 3f;
}
