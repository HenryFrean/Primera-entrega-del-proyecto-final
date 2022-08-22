using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   // private PlayerData playerData;
    private MovementPlayer playerMove;

    private void Start()
    {
      //  playerData = GetComponent<PlayerData>();
        playerMove = GetComponent<MovementPlayer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Gold"))
        {
            Destroy(other.gameObject);
        }
    }
}
