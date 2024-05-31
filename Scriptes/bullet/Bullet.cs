using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float destroyTime;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Invoke("DestroyBullet",destroyTime);
    }

    void Update() => transform.Translate(Vector2.right *  speed * Time.deltaTime);
    
    void DestroyBullet() => Destroy(gameObject);

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (!collider.gameObject.tag.Equals("Player") && !collider.gameObject.tag.Equals("Enemy bullet"))
            Destroy(gameObject);
    }
}
