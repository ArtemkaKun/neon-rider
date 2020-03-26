using UnityEngine;

public class MoveController : MonoBehaviour
{
    private Rigidbody2D car_rigidbody;

    private void Start()
    {
        car_rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        car_rigidbody.AddTorque(-1 * Input.GetAxis("Horizontal") * 75f * Time.fixedDeltaTime);
    }
}