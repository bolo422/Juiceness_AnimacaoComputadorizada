using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSelected : Selected
{
    [SerializeField] private Material mat;
    [SerializeField] private Material sel_mat;

    [SerializeField] private SkinnedMeshRenderer mesh;

    
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
            ChangeMateral(mesh, sel_mat);
        }
        else
        {
            ChangeMateral(mesh, mat);
        }
    }

    protected override void ChangeMateral(Renderer mr, Material mat)
    {
        Material[] mats = mr.materials;
        mats[0] = mat;
        mr.materials = mats;
    }

    public override void HoverSwitch()
    {
        hover = !hover;
    }
    
    public override void HoverSwitch(bool newValue)
    {
        hover = newValue;
    }
}
