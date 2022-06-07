using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence sharedInstance;
   public string nombrePlayer;
    public int nivel;
    public float Volumen;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(sharedInstance);
        }
        else
        {
            Destroy(this);
        }
    }

    public void Data()
    {
    PlayerPrefs.SetString("NombrePlayer", nombrePlayer);

    PlayerPrefs.SetInt("Nivel", nivel);

    PlayerPrefs.SetFloat("VOLUMEN", Volumen);
    }

}
