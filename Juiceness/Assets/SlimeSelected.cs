using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class SlimeSelected : MonoBehaviour
{
    [SerializeField] private Material light;
    [SerializeField] private Material sel_light;
    [SerializeField] private Material dark;
    [SerializeField] private Material sel_dark;
    [SerializeField] private Material outline;
    [SerializeField] private Material sel_outline;

    [SerializeField] private MeshRenderer darkerMesh;
    [SerializeField] private MeshRenderer lighterMesh;
    [SerializeField] private MeshRenderer outlineMesh;
    
    [SerializeField] bool hover = false;
    private bool oldHover;

    private void Start()
    {
        oldHover = hover;
    }

    private void Update()
    {
        if (oldHover == hover) return;

        oldHover = hover;
        
        if (hover)
        {
            ChangeMateral(darkerMesh, sel_dark);
            ChangeMateral(lighterMesh, sel_light);
            ChangeMateral(outlineMesh, sel_outline);
        }
        else
        {
            ChangeMateral(darkerMesh, dark);
            ChangeMateral(lighterMesh, light);
            ChangeMateral(outlineMesh, outline);
        }
    }

    private void ChangeMateral(MeshRenderer mr, Material mat)
    {
        Material[] mats = mr.materials;
        mats[0] = mat;
        mr.materials = mats;
    }

    public void HoverSwitch()
    {
        hover = !hover;
    }
}
