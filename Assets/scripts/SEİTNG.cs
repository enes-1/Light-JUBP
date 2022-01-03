using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SEİTNG : MonoBehaviour
{
    public void EasyToseting()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
    }
    public void NormalToseting()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
    }
    public void HardToseting()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void MenuToseting()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +5);
    }
}
