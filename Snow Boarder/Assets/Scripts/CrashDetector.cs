using System;
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
    Boolean preventDP = true;
    void OnTriggerEnter2D(Collider2D other) {
    // void OnCollisionEnter2D(Collision2D other) {
        if(other.tag == "Ground" && preventDP) 
        {
            preventDP = false;
            crashEffect.Play();
            Debug.Log("You dead!");
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            FindObjectOfType<PlayerController>().DisableControls();
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
        preventDP = true;
    }
}
