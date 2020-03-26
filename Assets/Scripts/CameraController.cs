using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject car;
    void Update()
    {
        var car_position = car.transform.position;
        transform.position = new Vector3(car_position.x, car_position.y, -10);
    }
}
