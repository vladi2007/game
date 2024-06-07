using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deepDark : MonoBehaviour
{
    player player;
    void Start() => player = FindObjectOfType<player>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    } 
}
