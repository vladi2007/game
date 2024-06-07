using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    private bool movingDirection;
    [SerializeField] float upBorder = -2.1f;
    [SerializeField] float downBorder = -9.7f;
    [SerializeField] public float speed = 3f;
    void FixedUpdate()
    {
        if (transform.position.y > upBorder)
            movingDirection = false;
        if (transform.position.y < downBorder)
            movingDirection = true;
        if (movingDirection)
            transform.position = new Vector3(transform.position.x, transform.position.y + speed*Time.deltaTime);    
        if (!movingDirection)
            transform.position = new Vector3(transform.position.x, transform.position.y - speed*Time.deltaTime);    
    }
}