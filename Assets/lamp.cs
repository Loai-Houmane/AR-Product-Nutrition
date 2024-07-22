using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class lamp : MonoBehaviour
{
    public float initialDuration = 0.5f;
    private float duration = 0.5f;
    public GameObject lamps;
    bool activated = false;

    void FixedUpdate()
    {
        if (duration < 0)
        {
            // Reset duration
            duration = initialDuration;
            lamps.SetActive(activated);
            activated = !activated;
        }
        else
        {
            // Decrease duration by the time passed since the last frame
            duration -= Time.deltaTime;
        }
    }
}
