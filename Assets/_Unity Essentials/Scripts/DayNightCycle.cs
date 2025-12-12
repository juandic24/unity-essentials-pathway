using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Cycle Settings")]
    [Tooltip("How many real-time seconds a full 360° day should last.")]
    public float dayDurationInSeconds = 60f;  // 1 minute = 1 full day

    // Update is called once per frame
    void Update()
    {
        // Prevent division by zero
        if (dayDurationInSeconds <= 0f)
            return;

        // Degrees to rotate per second to complete 360° in 'dayDurationInSeconds'
        float degreesPerSecond = 360f / dayDurationInSeconds;

        // Rotate the light around the X axis
        transform.Rotate(Vector3.right * degreesPerSecond * Time.deltaTime);
    }
}
