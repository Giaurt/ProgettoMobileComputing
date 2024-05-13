using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiAuthManager : MonoBehaviour
{
    public static UiAuthManager instance;

    //Screen object variables
    public GameObject loginUI;
    public GameObject registerUI;
    public GameObject startUI;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
        
    }

    //Functions to change the login screen UI
    public void LoginScreen() //Back button
    {
        FindAnyObjectByType<AudioManager>().Play("UISound");
        loginUI.SetActive(true);
        registerUI.SetActive(false);
    }
    public void RegisterScreen() // Regester button
    {
        FindAnyObjectByType<AudioManager>().Play("UISound");
        loginUI.SetActive(false);
        registerUI.SetActive(true);
    }
    public void LoggedIn(){
        loginUI.SetActive(false);
        startUI.SetActive(true);
        Debug.LogWarning("Logged In UI");
    }
    
}
