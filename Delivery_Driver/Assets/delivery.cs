using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{
    int package = 0;
    bool hasPackage = false;

    [SerializeField] float DestroyTime = 0.1f;

    void Start() {
        Debug.Log("has Packaged ? : " + hasPackage);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Boom!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && !hasPackage) {
            Debug.Log("Got package!");
            hasPackage = true;
            Destroy(other.gameObject, DestroyTime);
        }

        if(other.tag == "Customer" && hasPackage) {
            Debug.Log("delivered package");
            hasPackage = false;
        }
    }
}
