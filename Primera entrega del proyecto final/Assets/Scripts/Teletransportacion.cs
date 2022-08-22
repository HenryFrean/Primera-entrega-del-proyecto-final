using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportacion : MonoBehaviour
{
    [SerializeField]
    [Range(2, 10)]
    private float cooldown;

    [SerializeField]
    Transform nextposition;

    private float timeInWall = 0;


    private void OnTriggerEnter(Collider other)
    {
        timeInWall = 0;
    }

    private void OnTriggerStay(Collider other)
    {
        timeInWall += Time.deltaTime;
        if (timeInWall >= cooldown)
        {
            other.transform.position = nextposition.position;
        }
    }
}
