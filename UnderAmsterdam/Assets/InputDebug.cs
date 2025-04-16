using UnityEngine;
using UnityEngine.XR;

public class HeadTrackingDebug : MonoBehaviour
{
    void Update()
    {
        InputDevice headDevice = InputDevices.GetDeviceAtXRNode(XRNode.Head);
        if (headDevice.isValid)
        {
            if (headDevice.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 pos) &&
                headDevice.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion rot))
            {
                Debug.Log("HMD Position: " + pos + ", Rotation: " + rot.eulerAngles);
            }
            else
            {
                Debug.Log("HMD is valid but position/rotation not available");
            }
        }
        else
        {
            Debug.Log("No valid HMD device found.");
        }
    }
}