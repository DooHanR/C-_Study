using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject thingtoFollow;
    void LateUpdate()
    {
        transform.position = thingtoFollow.transform.position + new UnityEngine.Vector3 (0, 0, -10); 
    }
}
