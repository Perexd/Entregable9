using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class gamemanager : MonoBehaviour
{
    public TMP_InputField nombre;
    private int level;
    private int minLevel = 1;
    private int maxLevel = 8;
    public GameObject Opciones1;
    public Text loadedLevel;

    public void escene()
    {
        SceneManager.LoadScene(1);
    }

 public void SaveUserOptions()
    {
        DataPersistence.sharedInstance.nivel = level;

        DataPersistence.sharedInstance.nombrePlayer = nombre.text;


        DataPersistence.sharedInstance.Data();
    }

    public void LoadUserOptions()

    {
    nombre.text = PlayerPrefs.GetString("NombrePlayer");
        level = PlayerPrefs.GetInt("Nivel");
        UpdateLevel();
    }
    void Start()
    {
        Opciones1.SetActive(false);

        level = int.Parse(loadedLevel.text);
        LoadUserOptions();
       
    }

    public void Opciones()
    {
        Opciones1.SetActive(true);
    }

    public void CerrarOpciones()
    {
        Opciones1.SetActive(false);
    }
    public void Plus()
    {
        level++;
        level = Mathf.Clamp(level, minLevel, maxLevel);
        UpdateLevel();
    }

    public void Minus()
    {
        level--;
        level = Mathf.Clamp(level, minLevel, maxLevel);
        UpdateLevel();
    }

    private void UpdateLevel()
    {
        loadedLevel.text = level.ToString();
    }

}