using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }
}
