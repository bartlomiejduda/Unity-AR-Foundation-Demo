using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;

    //Shoot Pistol
    public void Shoot()
    {

        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if ( hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon2(Clone)" || hit.transform.name == "balloon3(Clone)" )
            {
                GameObject audio_play_script = GameObject.Find("PlayAudioScript");
                audio_play_script.GetComponent<PlayTargetAudio>().playTargAudio("Baloon");

            }


            if (hit.transform.name.Contains("Cube") )
            {
                AudioSource audioData = hit.transform.gameObject.GetComponent<AudioSource>();

                if ( hit.transform.name.Contains("CubeBrick") )
                {
                    GameObject audio_play_script = GameObject.Find("PlayAudioScript");
                    audio_play_script.GetComponent<PlayTargetAudio>().playTargAudio("CubeBrick");
                }
                else if (hit.transform.name.Contains("CubeWater"))
                {
                    GameObject audio_play_script = GameObject.Find("PlayAudioScript");
                    audio_play_script.GetComponent<PlayTargetAudio>().playTargAudio("CubeWater");
                }    
                
            }

            GameObject.Find("PointAddingScript")
                    .GetComponent<ManagePointsScript>().add_points(hit.transform.gameObject);
            Destroy(hit.transform.gameObject); //destroy target when shooting by pistol

            if (!hit.transform.gameObject.name.Contains("balloon"))
            {
                GameObject inst_script = GameObject.Find("InstantiateScript");
                inst_script.GetComponent<CreateInstance>().create_instance_func(
                    hit.transform.gameObject.transform.position, hit.transform.gameObject); //new instance
            }


        }
    }
}
