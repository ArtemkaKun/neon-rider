using System;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private Rigidbody2D _carRigidbody;

    private void Start()
    {
        _carRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _carRigidbody.angularVelocity += -1 * Input.GetAxis("Horizontal") * 150f;
        //_carRigidbody.AddTorque(-1 * Input.GetAxis("Horizontal") * 150f);
    }
}