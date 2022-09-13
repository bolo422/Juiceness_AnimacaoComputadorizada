using UnityEngine;

public class CubeSelected : Selected
{
    [SerializeField] private Material mat;
    [SerializeField] private Material sel_mat;

    [SerializeField] private SkinnedMeshRenderer mesh;

    private bool oldHover;

    private void Start()
    {
        oldHover = hover;
    }

    private void Update()
    {
        CheckForRelevantAnimation();
        
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
