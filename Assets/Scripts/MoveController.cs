using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    void Update()
    {
        if (Math.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            var sphere = gameObject.GetComponent<WheelJoint2D>();
            sphere.useMotor = true;
            var joint_motor_2d = sphere.motor;
            joint_motor_2d.motorSpeed += Input.GetAxis("Horizontal") * 75f * Time.fixedDeltaTime;
            sphere.motor = joint_motor_2d;
        }
    }
}
