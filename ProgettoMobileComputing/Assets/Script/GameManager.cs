using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton(){
        FindAnyObjectByType<AudioManager>().Play("UISound");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitButton(){
        FindAnyObjectByType<AudioManager>().Play("UISound");
        Debug.Log("quit");
        Application.Quit();
    }
}
