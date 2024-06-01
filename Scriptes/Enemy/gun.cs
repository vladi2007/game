using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    player player;

    Enemy enemy;
    [SerializeField] float fireRate;
    [SerializeField] float nextFire;
    void Start()
    {
        enemy = FindAnyObjectByType<Enemy>();
        fireRate = 1f;
        nextFire = Time.time;
        player = FindObjectOfType<player>();
    }
    void Update() => CheakTimeToFire();

    void CheakTimeToFire()
    {
        if (nextFire <=0 && Math.Abs((player.transform.position - enemy.transform.position).magnitude) < 25 )
        {
            Instantiate(bullet, transform.position, transform.rotation);
            nextFire=fireRate;
        }    
        else
            nextFire -=Time.deltaTime;
    }
}
