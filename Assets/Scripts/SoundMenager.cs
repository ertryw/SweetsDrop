using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundMenager
{
    
   public static void Play(AudioClip clip)
    {
        GameObject soundGameObject = new GameObject("Soundgood");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        soundGameObject.AddComponent<destroy>();
        audioSource.PlayOneShot(clip);
    }


}
