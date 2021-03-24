using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TargetMovement : MonoBehaviour
{
    //Cube targets movement
    Vector3 start_pos;
    Vector3[] waypoints_brick;
    Vector3[] waypoints_water;

    public float speed = 20;    
    int targetNum_brick = 0;
    int targetNum_water = 0;

    void Start()
    {
        start_pos = this.gameObject.transform.position;

        Vector3[] waypoints_start = { new Vector3 { x = start_pos.x + 0.0f, y = start_pos.y + 0.0f, z = start_pos.z + 0.00f },
                                      new Vector3 { x = start_pos.x - 2.00f, y = start_pos.y + 0.0f, z = start_pos.z + 0.00f },
                                      new Vector3 { x = start_pos.x - 2.00f, y = start_pos.y + 2.00f, z = start_pos.z + 0.00f },
                                      new Vector3 { x = start_pos.x + 0.0f, y = start_pos.y + 2.00f, z = start_pos.z + 0.00f }
                                    };

        Vector3[] waypoints_start2 = { new Vector3 { x = start_pos.x + 0.0f, y = start_pos.y + 0.0f, z = start_pos.z + 0.00f },
                                       new Vector3 { x = start_pos.x + 1.00f, y = start_pos.y + 0.0f, z = start_pos.z + 0.00f },
                                       new Vector3 { x = start_pos.x + 0.50f, y = start_pos.y + 1.0f, z = start_pos.z + 0.00f }
                                     };

        waypoints_brick = waypoints_start;
        waypoints_water = waypoints_start2;

    }


    void Update()
    {
        Vector3 curr_pos = this.gameObject.transform.position;

        //Brick cube movement
        if (  this.gameObject.name.Contains("CubeBrick") )
         { 
            transform.position = Vector3.MoveTowards(curr_pos, waypoints_brick[targetNum_brick], 
                speed * Time.deltaTime);

             //if we reach it, go on to the next one
            if (transform.position == waypoints_brick[targetNum_brick])
            {
                targetNum_brick = (targetNum_brick + 1) % waypoints_brick.Length;
            }

        }

        //Water Cube Movement
        else if (this.gameObject.name.Contains("CubeWater"))
        {
            transform.position = Vector3.MoveTowards(curr_pos, waypoints_water[targetNum_water],
                  speed * Time.deltaTime);

            //if we reach it, go on to the next one
            if (transform.position == waypoints_water[targetNum_water])
            {
                targetNum_water = (targetNum_water + 1) % waypoints_water.Length;
            }

        }
    }


}
