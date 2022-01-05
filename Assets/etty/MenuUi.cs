using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUi : MonoBehaviour
{

    [SerializeField] private InputField inputField2;
    [SerializeField] private InputField inputField3;

    public string myName2;
    public string myName3;

   
    public void LoadScene()
    {

        PlayerPrefs.GetString("name2");
        PlayerPrefs.GetString("name3");

        SceneManager.LoadScene(1);
    }

    public void AddPlayerName()
    {
        myName2 = inputField2.text;
        myName3 = inputField3.text;
        PlayerPrefs.SetString("name3", myName3);
        PlayerPrefs.SetString("name2", myName2);
      


    }

    
}


