using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    private Vector3 pos;
    Camera main;
    void Start() => main = FindObjectOfType<Camera>();
    void Update()
    {
        Flip();
        pos = main.WorldToScreenPoint(transform.position); 
    }

    void Flip()
    { 
        if (Input.mousePosition.x < pos.x)
            transform.localRotation = Quaternion.Euler(0,180,0);
        if (Input.mousePosition.x > pos.x)
            transform.localRotation = Quaternion.Euler(0,0,0);    
    }
}