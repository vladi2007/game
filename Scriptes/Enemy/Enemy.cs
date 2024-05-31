using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int healthPoint = 100;
    player player;
    void Start() => player = FindObjectOfType<player>();
    void Update()
    {
        GoToPlayer();
        if (healthPoint <=0)
            Destroy(gameObject);
    }

    private void GoToPlayer()
    {             
        if (transform.position.x < player.transform.position.x)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        else
            transform.localRotation = Quaternion.Euler(0, 0, 0);        
    }
    
    void TakeDamage() => healthPoint -= 25;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals("Bullet"))
            TakeDamage();
    }
}
