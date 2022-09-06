using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeboy : MonoBehaviour
{

    private Animator animator;

    [SerializeField] private GameObject slime_fill;
    [SerializeField] private GameObject slime_eyes;
    [SerializeField] private GameObject slime_skin;
    [SerializeField] private GameObject slime_outline;

    private Material slimeOriginal_fill;
    private Material slimeOriginal_eyes;
    private Material slimeOriginal_skin;
    private Material slimeOriginal_outline;

    [SerializeField] private Material slimeAlternative_fill;
    [SerializeField] private Material slimeAlternative_eyes;
    [SerializeField] private Material slimeAlternative_skin;
    [SerializeField] private Material slimeAlternative_outline;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        slimeOriginal_fill = slime_fill.GetComponent<MeshRenderer>().materials[0];
        slimeOriginal_eyes = slime_eyes.GetComponent<MeshRenderer>().materials[0];
        slimeOriginal_skin = slime_skin.GetComponent<MeshRenderer>().materials[0];
        slimeOriginal_outline = slime_outline.GetComponent<MeshRenderer>().materials[0];
    }

    public void hitHammer()
    {
        animator.CrossFade("slime_ybot_casting 1", 0.2f);
    }

    public void hoverEnterSlime()
    {
        slime_fill.GetComponent<MeshRenderer>().materials[0] = slimeAlternative_fill;
        slime_eyes.GetComponent<MeshRenderer>().materials[0] = slimeAlternative_eyes;
        slime_skin.GetComponent<MeshRenderer>().materials[0] = slimeAlternative_skin;
        slime_outline.GetComponent<MeshRenderer>().materials[0] = slimeAlternative_outline;
        Debug.Log("hover Enter slime");
    }

    public void hoverExitSlime()
    {
        slime_fill.GetComponent<MeshRenderer>().materials[0] =      slimeOriginal_fill;
        slime_eyes.GetComponent<MeshRenderer>().materials[0] =      slimeOriginal_eyes;
        slime_skin.GetComponent<MeshRenderer>().materials[0] =      slimeOriginal_skin;
        slime_outline.GetComponent<MeshRenderer>().materials[0] =   slimeOriginal_outline;
        Debug.Log("hover Exit slime");
    }

}
