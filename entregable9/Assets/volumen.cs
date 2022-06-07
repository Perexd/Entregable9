using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumen : MonoBehaviour
{
  private AudioSource Audio;
    public float musicVolume;

    void Start()
    {
        LoadUserOptions();
        Audio = GetComponent<AudioSource>();
    }


    void Update()
    {
       Audio.volume = musicVolume;
    }

    public void SaveUserOptions()
    {
        DataPersistence.sharedInstance.Volumen = musicVolume;
    }

    public void LoadUserOptions()
    {

        musicVolume = PlayerPrefs.GetFloat("VOLUMEN");
    }


    public void UpdateVolume(float volume)
    {
        musicVolume = volume;
    }
}
