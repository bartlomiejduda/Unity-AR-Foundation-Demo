using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class DebugMenuScript : MonoBehaviour
{

    public ARSession ar_session;
    private string currentTime;
    public Text debug_text;
    
    void Update()
    {
        GameObject ar_cam = GameObject.Find("AR Camera");
        ARCameraManager ar_man = ar_cam.GetComponent<ARCameraManager>();
        string ar_man_permission;
        if ( ar_man.permissionGranted == true)
        {
            ar_man_permission = "true";
        }
        else
        {
            ar_man_permission = "false";
        }

        currentTime = Time.time.ToString("f1");
        currentTime = "Elapsed time: " + currentTime + " sec.";
        debug_text.text = "Debug menu:\n" +
                           currentTime + "\n" +
                           "Session state: " + ARSession.state + "\n" +
                           "CameraPerm: " + ar_man_permission;



    }
}
