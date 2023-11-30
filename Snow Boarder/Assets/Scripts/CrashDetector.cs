using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayTime = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    // Start is called before the first frame update
    // void OnCollisionEnter2D(Collision2D other) {
    //     Debug.Log("Boom!");
    // }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground") 
        {
            Invoke("ReloadScene", delayTime);
            crashEffect.Play();
            Debug.Log("You dead!");
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
