using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileShooter : MonoBehaviour
{

    GameObject prefab;

    void Start()
    {
        prefab = Resources.Load("ShootBall") as GameObject;
    }

   
    void Update()
    {
        if ( Input.GetMouseButtonDown(0) )
        {
            GameObject ch_button = GameObject.Find("ButtonChooseWeapon");
            Text curr_text = ch_button.GetComponentInChildren<Text>();

            if (curr_text.text.Contains("Pistol"))
            {
                //shoot pistol
                GameObject shoot_script = GameObject.Find("ShootScript");
                shoot_script.GetComponent<ShootScript>().Shoot();
            }
            else if (curr_text.text.Contains("Balls"))
            {
                //shoot balls
                GameObject projectile = Instantiate(prefab) as GameObject;
                projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = Camera.main.transform.forward * 30;
            }
            else
            {
                Debug.Log("Wrong weapon");
            }

        }
    }
    
     
}
