using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPoint : MonoBehaviour
{
    player player;
    void Start() => player = GameObject.FindObjectOfType<player>();

    void TakeDamage(int damage)
    {
        player.HealthPoint -= damage;
        if (player.HealthPoint <=0)
            Destroy(gameObject);     
    }
}