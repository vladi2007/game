using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    private bool movingDirection;

    [SerializeField] public float speed = 3f;


    void FixedUpdate()
    {
        if (transform.position.y > -2.1f)
            movingDirection = false;
        if (transform.position.y < -9.7f)
            movingDirection = true;
        if (movingDirection)
            transform.position = new Vector3(transform.position.x, transform.position.y + speed*Time.deltaTime);    
        if (!movingDirection)
            transform.position = new Vector3(transform.position.x, transform.position.y - speed*Time.deltaTime);    
    }
    
}
