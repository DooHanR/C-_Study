using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    // Start is called before the first frame update
    // void OnCollisionEnter2D(Collision2D other) {
    //     Debug.Log("Boom!");
    // }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground") 
        {
            SceneManager.LoadScene(0);
            Debug.Log("You dead!");
        }
    }
}
