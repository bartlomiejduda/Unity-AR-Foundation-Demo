using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseWeapon : MonoBehaviour
{

    public void change_weapon()
    {
        GameObject ch_button = GameObject.Find("ButtonChooseWeapon");

        Text curr_text = ch_button.GetComponentInChildren<Text>();

        if ( curr_text.text.Contains("Pistol"))
        {
            ch_button.GetComponentInChildren<Text>().text = "Weapon: Balls";
        }
        else
        {
            ch_button.GetComponentInChildren<Text>().text = "Weapon: Pistol";
        }
    }

}
