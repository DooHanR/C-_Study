using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;
    void Start()
    {
           
    }

    /** 이게 프레임당 이동인데, 프레임 많은 컴이면 빨리 움직임.
    그래서 각 프레임 시간. 1초에 100프레임이면 1프레임당 0.01초
    1초에 10프레임이면 1프레임당 0.1초를 각가 곱해줘서 일정하게.
    ex) 1 * 100 * 0.01 = 1.
    1 * 10 * 0.1 = 1. 그래서 똥컴이든 뭐든간에 동일한 값을 얻게.
    */

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
