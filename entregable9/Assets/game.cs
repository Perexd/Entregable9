using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class game : MonoBehaviour
{
    public static game sharedInstance;
    public TextMeshProUGUI level;
    public TextMeshProUGUI username;
    private AudioSource Audio;
    public float musicVolume;
    public float vol;
    public TextMeshProUGUI volumen;


    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        ApplyUserOptions();
        Audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        Audio.volume = musicVolume;
    }

    public void ApplyUserOptions()
    {
        musicVolume = DataPersistence.sharedInstance.Volumen;
        vol = DataPersistence.sharedInstance.Volumen;
        volumen.text = vol * 100 + "%".ToString();
        level.text = DataPersistence.sharedInstance.nivel.ToString();
        username.text = DataPersistence.sharedInstance.nombrePlayer;
    }

     public void escene()
    {
        SceneManager.LoadScene(0);
    }
    
}
