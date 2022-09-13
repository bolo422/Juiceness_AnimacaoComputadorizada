using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAndSlime : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private ParticleSystem slimeParticles;
    [SerializeField] private ParticleSystem marretaParticles;

    private SlimeSelected slimeSelected;
    private CubeSelected cubeSelected;
    public AudioSource cuboSlime;
    public AudioClip cuboSquish;
    public AudioClip cuboReverseSquish;
    public AudioClip cubo;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        slimeSelected = GetComponentInChildren<SlimeSelected>();
        cubeSelected = GetComponentInChildren<CubeSelected>();
    }

    public void smashSlime()
    {
        
        Selected[] selecteds = GetComponentsInChildren<Selected>();

        foreach (Selected s in selecteds)
        {
            s.HoverSwitch(false);
        }
        
        animator.CrossFade("smashSlime", 0.2f);
        StartCoroutine(cubeAndSlimeParticles());
    }

    public void recover()
    {
        Selected[] selecteds = GetComponentsInChildren<Selected>();

        foreach (Selected s in selecteds)
        {
            s.HoverSwitch(false);
        }
        
        animator.CrossFade("recover", 0.2f);
        cuboSlime.PlayOneShot(cuboReverseSquish);
        cuboSlime.volume = 1.0f;
    }
    

    IEnumerator cubeAndSlimeParticles()
    {
        //yield return new WaitForSeconds(0.20f);
        // marretaParticles.Play();
        cuboSlime.PlayOneShot(cubo);
        cuboSlime.volume = 1.0f;
        yield return new WaitForSeconds(1.10f);
        cuboSlime.PlayOneShot(cuboSquish);
        cuboSlime.volume = 1.0f;
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
    
    public void CubeHoverEnter()
    {
        cubeSelected.HoverSwitch(true);
    }

    public void CubeHoverExit()
    {
        cubeSelected.HoverSwitch(false);
    }
}
