using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneTrigger : MonoBehaviour
{
    player player;
    void Start() => player = FindObjectOfType<player>();
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals("Player"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
