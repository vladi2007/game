using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody2D rb;

    player target;
        
    Vector2 moveDirection;

    public float destroyTime;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<player>();
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.tag.Equals("Enemy") && !other.gameObject.tag.Equals("Bullet") )
            Destroy(gameObject);
    }

   
}
