using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTargetAudio : MonoBehaviour
{
    public void playTargAudio(string ObjectName)
    {
        if (ObjectName == "CubeBrick")
        {
            GameObject audio_ob = GameObject.Find("AudioCubeBrick");
            audio_ob.GetComponent<AudioSource>().Play();
        }
        else if (ObjectName == "CubeWater")
        {
            GameObject audio_ob = GameObject.Find("AudioCubeWater");
            audio_ob.GetComponent<AudioSource>().Play();
        }
        else if (ObjectName == "Baloon")
        {
            GameObject audio_ob = GameObject.Find("AudioBaloon");
            audio_ob.GetComponent<AudioSource>().Play();
        }
        else
        {
            Debug.Log("Wrong Audio");
        }

    }
}
