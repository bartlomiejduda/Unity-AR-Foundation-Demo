using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateInstance : MonoBehaviour
{
    //create new instance of a target object
    public void create_instance_func(Vector3 old_pos, GameObject old_obj)
    {
        int how_many_obj = Random.Range(1, 3);

        for (int i=0; i < how_many_obj; i++)
        {
            float x_new = Random.Range(old_pos.x - 2.5f, old_pos.x + 3.5f);
            float y_new = Random.Range(old_pos.y - 2.0f, old_pos.y + 2.0f);
            float z_new = Random.Range(old_pos.z, old_pos.z + 0.5f);

            Vector3 new_pos = new Vector3 { x = x_new, y = y_new, z = z_new };

            GameObject new_obj = Instantiate(old_obj, new_pos, Quaternion.identity);
            new_obj.GetComponent<TargetMovement>().enabled = true;
        }


    }
}
