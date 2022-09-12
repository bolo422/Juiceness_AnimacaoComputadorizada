using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAndSlime : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private ParticleSystem slimeParticles;
    [SerializeField] private ParticleSystem marretaParticles;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void smashSlime()
    {
        animator.CrossFade("smashSlime", 0.2f);
        //StartCoroutine(cubeAndSlimeParticles());
    }

    public void recover()
    {
        animator.CrossFade("recover", 0.2f);
    }
    

    IEnumerator cubeAndSlimeParticles()
    {
        yield return new WaitForSeconds(0.20f);
        marretaParticles.Play();

        yield return new WaitForSeconds(2.11f);
        slimeParticles.Play();

    }
}
