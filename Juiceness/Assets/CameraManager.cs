using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] Transform[] cameraPositions;
    [SerializeField] int selectedPosition = 0;
    GameObject camera;
    private float desiredDuration = 5f;
    private float elapsedTime;

    private void Awake()
    {
        camera = GetComponentInChildren<Camera>().gameObject;
    }
    
    void Update()
    {

        /*if (Input.GetKey(KeyCode.Escape))
        {
            Debug.LogError("Quitting Aplication");
            Application.Quit();
        }*/


        if (camera.transform.position != cameraPositions[selectedPosition].position
            || camera.transform.rotation != cameraPositions[selectedPosition].rotation)
        {
            elapsedTime += Time.deltaTime;
            float percentageComplete = elapsedTime / desiredDuration;
            
            camera.transform.position =
                Vector3.Lerp(camera.transform.position, cameraPositions[selectedPosition].position, percentageComplete);

            camera.transform.rotation = Quaternion.Lerp(camera.transform.rotation,
                cameraPositions[selectedPosition].rotation, percentageComplete);
        }
    }

    public void ChangePosition(int desiredPosition)
    {
        selectedPosition = desiredPosition;
        elapsedTime = 0;
    }
    
    public void ChangePosition()
    {
        ChangePosition(
            selectedPosition == cameraPositions.Length-1 ?
                0 :
                selectedPosition+1
            );
    }
}
