using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARCameraBackground))]
public class ARCameraBackgroundFixer : MonoBehaviour
{
    private ARCameraBackground arBackground;
    private Camera cam;

    void Awake()
    {
        arBackground = GetComponent<ARCameraBackground>();
        cam = GetComponent<Camera>();
    }

    void OnEnable()
    {
        // Tvingar URP att uppdatera AR-bakgrunden varje frame
        if (arBackground != null)
        {
            arBackground.useCustomMaterial = false;
            arBackground.enabled = false;
            arBackground.enabled = true;
            Debug.Log("✅ AR Camera Background manually restarted.");
        }

        if (cam != null)
        {
            cam.clearFlags = CameraClearFlags.Depth;
            cam.backgroundColor = Color.black;
        }
    }
}
