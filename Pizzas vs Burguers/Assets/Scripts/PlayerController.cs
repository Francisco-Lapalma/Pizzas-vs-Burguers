using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private CharacterController ccPlayer;
    [SerializeField] protected PlayerData playerStats;

    void Start()
    {
        ccPlayer = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
        PlayerGravity();
    }

    private void PlayerGravity()
    {
        ccPlayer.Move(transform.TransformDirection(Vector3.down) * playerStats.playerGravity * Time.deltaTime);
    }

    private void MovePlayer(Vector3 direction)
    {
        ccPlayer.Move(playerStats.playerSpeed * Time.deltaTime * transform.TransformDirection(direction));
    }

    private void MovementPlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }
    }
}
