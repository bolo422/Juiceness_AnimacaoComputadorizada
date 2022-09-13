using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationWatcher : MonoBehaviour
{
    public static AnimationWatcher Instance { get; private set; }
    
    
    public bool isRelevantAnimationPlaying = false;
    
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }

    public void DisableHover(float timeInSeconds)
    {
        StartCoroutine(disableHoverCoroutine(timeInSeconds));
    }
    
    IEnumerator disableHoverCoroutine(float timeInSeconds)
    {
        isRelevantAnimationPlaying = true;
        yield return new WaitForSeconds(timeInSeconds);
        isRelevantAnimationPlaying = false;
    }
}
