using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARCameraBackground))]
public class ARCameraBackgroundFixer : MonoBehaviour
{
    ARCameraBackground arBackground;

    void Start()
    {
        arBackground = GetComponent<ARCameraBackground>();
        InvokeRepeating(nameof(ForceEnableBackground), 0.5f, 2f);
    }

    void ForceEnableBackground()
    {
        if (arBackground != null && !arBackground.enabled)
        {
            Debug.Log("🔧 Restarting ARCameraBackground");
            arBackground.enabled = true;
        }

        // Säkerställ att kamerans clear-flags är korrekt
        var cam = GetComponent<Camera>();
        if (cam != null)
        {
            cam.clearFlags = CameraClearFlags.Nothing;
        }
    }
}

