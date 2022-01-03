using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveller : MonoBehaviour
{
    public void Easylevel()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void Normalslevel()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
    }
    public void Hardlevel()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
    }
}
