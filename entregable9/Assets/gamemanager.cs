using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public GameObject Opciones1;


    public string namePlayer;
    public string saveName;

    public Text inputText;
    public Text loadedName;
     
 
    void Start()
    {
        Opciones1.SetActive(false);
       
    }

    void Update()
    {
        namePlayer = PlayerPrefs.GetString("name", "none");
        loadedName.text = namePlayer;
    }

    public void Opciones()
    {
        Opciones1.SetActive(true);
    }

    public void CerrarOpciones()
    {
        Opciones1.SetActive(false);
    }

    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }
    
   

}