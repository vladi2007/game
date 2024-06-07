using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Animations;

public class gun : MonoBehaviour
{
    [SerializeField] float offSet;
    void Update()
    {
        var mousePosition = Input.mousePosition;
        //mousePosition.z = transform.position.z - Camera.main.transform.position.z; // это только для перспективной камеры необходимо
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); //положение мыши из экранных в мировые координаты
        var angle = Vector2.Angle(Vector2.right, mousePosition - transform.position);//угол между вектором от объекта к мыше и осью х
        transform.eulerAngles = new Vector3(0f, 0f, transform.position.y < mousePosition.y ? angle : -angle);//немного магии на последок
        Vector3 localScale = Vector3.one;
        if (angle > 90 || angle < -90)
            localScale.y = -1f;
        else
            localScale.y = +1f;
        transform.localScale = localScale;
    } 
}