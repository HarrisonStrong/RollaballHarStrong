using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float angleSpeed = 30;
    public float _min = 350;
    public float _max = 10;

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.y >= _max && transform.eulerAngles.y <= _min)
        {
            angleSpeed *= -1;
        }
        transform.Rotate(new Vector3(0, angleSpeed, 0) * Time.deltaTime);
    }
}
