using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ForceARStart : MonoBehaviour
{
    ARSession session;
    ARCameraBackground bg;

    void Start()
    {
        session = FindObjectOfType<ARSession>();
        bg = FindObjectOfType<ARCameraBackground>();

        if (session != null)
        {
            session.enabled = false;
            session.Reset();
            session.enabled = true;
            Debug.Log("🔄 ARSession restarted manually.");
        }

        if (bg != null)
        {
            bg.enabled = false;
            bg.enabled = true;
            Debug.Log("🎥 ARCameraBackground restarted manually.");
        }
    }
}