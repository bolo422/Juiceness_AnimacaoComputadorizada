using System;
using System.Collections;
using UnityEngine;

public class slimeboy : MonoBehaviour
{

    private Animator animator;

    [SerializeField] private ParticleSystem slimeParticles;
    [SerializeField] private ParticleSystem marretaParticles;

    private SlimeSelected slimeSelected;

    [SerializeField] private AudioSource marreta_AS;
    [SerializeField] private AudioSource squish_AS;
    [SerializeField] private AudioSource powerUp_AS;

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
        AnimationWatcher.Instance.DisableHover(4.8f);
        StartCoroutine(hammerAndSlimeParticles());
    }

    IEnumerator hammerAndSlimeParticles()
    {
        yield return new WaitForSeconds(0.10f);
        marretaParticles.Play();
        powerUp_AS.PlayOneShot(powerUp_AS.clip);

        yield return new WaitForSeconds(2.11f);
        marreta_AS.PlayOneShot(marreta_AS.clip);
        squish_AS.PlayOneShot(squish_AS.clip);
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
