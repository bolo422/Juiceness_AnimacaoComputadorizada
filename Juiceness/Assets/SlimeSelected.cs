using UnityEngine;

public class SlimeSelected : Selected
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
