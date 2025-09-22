using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Length Settings")]
    [Tooltip("Duration of a full day cycle in seconds.")]
    [Range(10f, 86400f)] // Optional: Clamp between 10 sec and 24 hours
    public float dayDurationInSeconds = 120f;

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees per full day
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate the light based on time
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
