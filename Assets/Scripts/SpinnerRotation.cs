using UnityEngine;

public class SpinnerRotation : MonoBehaviour
{
    // Rotation speed in degrees per second
    public float rotationSpeed = 360f;

    void Update()
    {
        // Rotate around Z-axis
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
