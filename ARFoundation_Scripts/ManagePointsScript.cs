using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class ManagePointsScript : MonoBehaviour
{
    int points = 0;
    public void add_points(GameObject obj_destroyed)
    {
        Text p_text = GameObject.Find("PointsText").GetComponent<Text>();
        string o_name = obj_destroyed.name;

        if ( o_name.Contains("CubeBrick")  )
        {
            points += Random.Range(28, 42);
        }
        else if (o_name.Contains("CubeWater"))
        {
            points += Random.Range(11,27);
        }
        else if (o_name.Contains("balloon"))
        {
            points += 10;
        }
        else
        {
            Debug.Log("Unsupported points object: " + obj_destroyed.name);
        }

        if (points > 1000)
        {
            points = 1000;
        }


        p_text.text = "Points: " + points + "/1000";

        if (points >= 1000 )
        {
            p_text.text = "YOU WON!!!";
        }



    }
}
