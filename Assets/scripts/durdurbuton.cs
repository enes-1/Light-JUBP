using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class durdurbuton : MonoBehaviour
{
    
    public bool oyundurumu = false;
    public void oyundurdur()
    {
        if (oyundurumu == false)
        {
            Time.timeScale = 0f ;
            oyundurumu = true ;
        }
        else
        {
            Time.timeScale = 1f ;
            oyundurumu = false;
        }
    }
}
