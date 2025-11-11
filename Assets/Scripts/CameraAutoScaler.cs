using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraAutoScaler : MonoBehaviour
{
    private Camera cam;
    private float initialAspect;
    private float initialSize;

    void Start()
    {
        cam = GetComponent<Camera>();
        initialAspect = (float)Screen.width / Screen.height;
        initialSize = cam.orthographicSize;
    }

    void Update()
    {
        float currentAspect = (float)Screen.width / Screen.height;
        cam.orthographicSize = initialSize * (initialAspect / currentAspect);
    }
}
