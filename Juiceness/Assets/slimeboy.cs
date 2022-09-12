using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeboy : MonoBehaviour
{

    private Animator animator;

    [SerializeField] private ParticleSystem slimeParticles;
    [SerializeField] private ParticleSystem marretaParticles;

    private SlimeSelected slimeSelected;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        slimeSelected = GetComponentInChildren<SlimeSelected>();
    }

    public void hitHammer()
    {
        Selected[] selecteds = GetComponentsInChildren<Selected>();

        foreach (Selected s in selecteds)
        {
            s.HoverSwitch(false);
        }

        animator.CrossFade("slime_ybot_casting 1", 0.2f);
        StartCoroutine(hammerAndSlimeParticles());
    }

    IEnumerator hammerAndSlimeParticles()
    {
        yield return new WaitForSeconds(0.20f);
        marretaParticles.Play();

        yield return new WaitForSeconds(2.11f);
        slimeParticles.Play();

    }
    
    public void SlimeHoverEnter()
    {
        slimeSelected.HoverSwitch(true);
    }

    public void SlimeHoverExit()
    {
        slimeSelected.HoverSwitch(false);
    }

}
