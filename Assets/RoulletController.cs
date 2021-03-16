using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulletController : MonoBehaviour
{
    float rotSpeed = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 50.0f;
        }

        if (Input.GetMouseButtonDown(1))
        {
            this.rotSpeed = 0f;
        }

        this.rotSpeed *= 0.987f;
        transform.Rotate(0, 0, this.rotSpeed);
    }
}
