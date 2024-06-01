using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hill : MonoBehaviour
{
    player player;
    void Start() => player = GameObject.FindObjectOfType<player>();

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals("Player"))
        {
            player.HealthPoint +=25;
            if (player.HealthPoint > 100)
                player.HealthPoint = 100;
            Destroy(gameObject);
        } 
    }
}
