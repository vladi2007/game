using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float time;
    void Start() => rb = GetComponent<Rigidbody2D>();
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("player"))
            Invoke("FallPlatform", time);
    }
    void FallPlatform() => rb.isKinematic = false;
}