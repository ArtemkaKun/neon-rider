using System;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    void Update()
    {
        var sphere = gameObject.GetComponent<WheelJoint2D>();
        sphere.useMotor = true;
        
        var joint_motor_2d = sphere.motor;

        if (Math.Abs(joint_motor_2d.motorSpeed) < 3200)
        {
            joint_motor_2d.motorSpeed += Input.GetAxis("Horizontal") * 75f * Time.fixedDeltaTime;
        }

        sphere.motor = joint_motor_2d;
    }
}