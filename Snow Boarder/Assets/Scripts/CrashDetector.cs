using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayTime = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    // [SerializeField] AudioClip jumpSFX;
    // [SerializeField] AudioClip landSFX;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground") 
        {
            crashEffect.Play();
            Debug.Log("You dead!");
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
