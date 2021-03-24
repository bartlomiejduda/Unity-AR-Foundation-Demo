using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission : MonoBehaviour
{

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name.Contains("CubeBrick"))
        {
            GameObject audio_play_script = GameObject.Find("PlayAudioScript");
            audio_play_script.GetComponent<PlayTargetAudio>().playTargAudio("CubeBrick");
        }
        else if (col.gameObject.name.Contains("CubeWater"))
        {
            GameObject audio_play_script = GameObject.Find("PlayAudioScript");
            audio_play_script.GetComponent<PlayTargetAudio>().playTargAudio("CubeWater");
        }
        else if (col.gameObject.name.Contains("balloon"))
        {
            GameObject audio_play_script = GameObject.Find("PlayAudioScript");
            audio_play_script.GetComponent<PlayTargetAudio>().playTargAudio("Baloon");
        }
        else
        {
            Debug.Log("Not supported colission");
        }

        GameObject.Find("PointAddingScript")
                .GetComponent<ManagePointsScript>().add_points(col.gameObject);
        Destroy(col.gameObject); //destroy object after colission with ball

        if (!col.gameObject.name.Contains("balloon"))
        {
            GameObject inst_script = GameObject.Find("InstantiateScript");
            inst_script.GetComponent<CreateInstance>().create_instance_func(
                col.gameObject.transform.position, col.gameObject); //new instance
        }
        

    }


    
}
