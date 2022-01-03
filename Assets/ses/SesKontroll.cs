using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontroll : MonoBehaviour
{
   private AudioSource audioSrc;
   private float musicVolume;
    
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        audioSrc = GetComponent<AudioSource>();
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;

    }
}
