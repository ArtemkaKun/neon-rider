using System;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    void Update()
    {
        var sphere = gameObject.GetComponent<Rigidbody2D>();

        sphere.AddTorque(-1 * Input.GetAxis("Horizontal") * 75f * Time.fixedDeltaTime);
    }
}