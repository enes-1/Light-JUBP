using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYBUTON : MonoBehaviour
{
    public void LEVELscane()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
     public void Menuscane()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -5);
    }
    
    public void AyarlarMenu()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +5);
    }

    public void QuitButton()
    {
        Debug.Log ("quit");
        Application.Quit();
    }
}
