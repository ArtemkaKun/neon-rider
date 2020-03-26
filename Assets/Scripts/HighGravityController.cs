using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighGravityController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<Rigidbody2D>().gravityScale = 5;
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        other.GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
