using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 10f)]
    float speed = 2f;

    public Vector3 direction = new Vector3(3f, 0f, 0f);

    enum EnemyTypes {Artur, Charly, Frank};

    [SerializeField] EnemyTypes enemyType;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (enemyType)
        {
            case EnemyTypes.Artur:
                ScalePlayer();
                break;

            case EnemyTypes.Charly:
                RotatePlayer();
                break;


            case EnemyTypes.Frank:
                MoveSelected();
                break;
        }

    }

    private void ScalePlayer()
    {
       
        transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
    }

    private void RotatePlayer()
    {
        transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
    }

    private void MoveSelected()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

}
