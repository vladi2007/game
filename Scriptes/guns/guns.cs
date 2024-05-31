using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform BulletTransForm;
    public float StartTimeFire;
    private float TimeFire;
    void Start() => TimeFire = StartTimeFire;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (TimeFire <=0)
            {
                Instantiate(bullet, BulletTransForm.position, transform.rotation);
                TimeFire=StartTimeFire;
            }        
            else
                TimeFire -=Time.deltaTime;
        }
    }       
}
