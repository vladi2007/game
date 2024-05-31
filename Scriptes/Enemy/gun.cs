using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    player player;
    [SerializeField] float fireRate;
    [SerializeField] float nextFire;
    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
        player = FindObjectOfType<player>();
    }
    void Update() => CheakTimeToFire();

    void CheakTimeToFire()
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
