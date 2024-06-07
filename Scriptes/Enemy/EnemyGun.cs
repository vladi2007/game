using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    Enemy enemy;
    player player;
    [SerializeField] float fireRate = 1f;
    [SerializeField] float nextFire = 1f;
    [SerializeField] float distanceToshot =12f;
    void Start()
    {
        enemy = gameObject.GetComponentInParent<Enemy>();
        fireRate = 1f;
        player = FindObjectOfType<player>();
    }

    void Update() =>CheakTimeToFire(); 

    void CheakTimeToFire()
    {
        var ab = (enemy.transform.position - player.transform.position).magnitude;
        if (Math.Abs(ab) <= distanceToshot)
        {
            if (nextFire <=0)
            {
                Instantiate(bullet, transform.position, transform.rotation);
                nextFire=fireRate;
            }
            else
            nextFire -=Time.deltaTime;
        }
    }
}
