using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject hammerHitButton;
    [SerializeField] private GameObject cubeSmashButton;
    [SerializeField] private GameObject cubeRecoveryButton;
    [SerializeField] private GameObject smashGroup;

    enum CurrentState
    {
        hammer, smash, recovery
    }

    private CurrentState state = CurrentState.hammer;

    private void Start()
    {
        ChangeStatus();
    }

    public void ChangeStatus()
    {
        if (state == CurrentState.smash)
        {
            cubeRecoveryButton.SetActive(true);
            cubeSmashButton.SetActive(false);
            state = CurrentState.recovery;
        }
        else if (state == CurrentState.recovery)
        {
            cubeSmashButton.SetActive(true);
            cubeRecoveryButton.SetActive(false);
            state = CurrentState.smash;
        }
    }

    public void ChangeScene()
    {
        if (state == CurrentState.hammer)
        {
            hammerHitButton.SetActive(false);
            smashGroup.SetActive(true);
            
            if (cubeRecoveryButton.activeSelf)
                state = CurrentState.recovery;
            else
                state = CurrentState.smash;
        }
        else if (state is CurrentState.smash or CurrentState.recovery)
        {
            hammerHitButton.SetActive(true);
            smashGroup.SetActive(false);
            state = CurrentState.hammer;
        }
    }
}
