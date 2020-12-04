//Made by Jesus Papania
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Jesus Papania
 * Code for making game speed faster or slower and change text of button
 */
public class SpeedUp : MonoBehaviour
{
    public bool fast = false;
    private string speed = "";
    private Text currentSpeed;

    public void DoubleTime()
    {
        //if the current speed is fast then show speed down 
        if (fast == false)
        {
            Time.timeScale = 2f;
            fast = true;
            speed = "Speed Down";
        }
        else //the speed is normal and button shows speed up
        {
            Time.timeScale = 1f;
            fast = false;
            speed = "Speed Up";
        }
        //sets button text to speed variable
        GameObject speedText = GameObject.Find("CurrentSpeed");
        currentSpeed = speedText.GetComponent<Text>();
        currentSpeed.text = speed;
    }

}
