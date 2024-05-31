using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPoint : MonoBehaviour
{
    [SerializeField] int health = 100;
    player player;
    public Slider healthSl;
    void Update()
    {
        healthSl.value = health;
        var normalSpeed = player.speed;
        if (health <= 50)
            player.speed = player.hitSpeed;
        else
            player.speed = normalSpeed;
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        if (health <=0)
            Destroy(gameObject);     
    }
}