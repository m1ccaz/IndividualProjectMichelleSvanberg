using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARCameraBackground))]
public class EnableARCameraFeed : MonoBehaviour
{
    private ARCameraBackground arCameraBackground;

    void Awake()
    {
        arCameraBackground = GetComponent<ARCameraBackground>();
    }

    void Start()
    {
        if (arCameraBackground != null)
        {
            arCameraBackground.enabled = false;
            arCameraBackground.enabled = true;
            Debug.Log("✅ AR Camera Background manually restarted.");
        }
        else
        {
            Debug.LogWarning("⚠️ No ARCameraBackground found on this camera.");
        }
    }
}
