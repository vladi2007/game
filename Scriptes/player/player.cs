using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private Vector3 pos;
    Camera main;
    private Rigidbody2D rb;
    float speed = 4f;
    [SerializeField] public  int HealthPoint = 100;
    [SerializeField] private  float jumpForce = 5f;
    private float movement;
    [SerializeField] private SpriteRenderer playerSprite;
    void Start()
    {
        main = FindObjectOfType<Camera>();
        rb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
    } 
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Math.Abs(rb.velocity.y) < 0.1f)
            rb.AddForce(new Vector3(0, jumpForce), ForceMode2D.Impulse);
    }
    void Flip()
    { 
        if (Input.mousePosition.x < pos.x)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        if (Input.mousePosition.x > pos.x)
            transform.localRotation = Quaternion.Euler(0, 0, 0);                       
    }
    void Move()
    {
        movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * speed * Time.deltaTime;
    }
    void Update()
    {
        Flip();
        pos = main.WorldToScreenPoint(transform.position);
        Move();
        Jump();
        if (HealthPoint <=0)
            Destroy(gameObject);
    }
    void TakeDamage() => HealthPoint -=25;
    private void OnCollisionEnter2D(Collision2D coll)
	{
        if(coll.gameObject.tag == "Platforms")
            rb.transform.parent = coll.transform;
	}

	private void OnCollisionExit2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "Platforms")
            rb.transform.parent = null;
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals("Enemy bullet"))
            TakeDamage();
    }
}