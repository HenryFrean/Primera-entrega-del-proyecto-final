using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float liveTime = 4f;
    
    void Start()
    {
        Invoke("DestroyDelay", liveTime);
    }

    void Update()
    {

    }
    private void DestroyDelay()
    {
        Destroy(gameObject);
    }
}
