using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeboy : MonoBehaviour
{

    private Animator animator;

    [SerializeField] private ParticleSystem slimeParticles;
    [SerializeField] private ParticleSystem marretaParticles;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void hitHammer()
    {
        animator.CrossFade("slime_ybot_casting 1", 0.2f);
        StartCoroutine(hammerAndSlimeParticles());
    }

    public void hoverEnterSlime()
    {

    }

    public void hoverExitSlime()
    {

    }

    IEnumerator hammerAndSlimeParticles()
    {
        yield return new WaitForSeconds(0.20f);
        marretaParticles.Play();

        yield return new WaitForSeconds(2.11f);
        slimeParticles.Play();

    }

}
