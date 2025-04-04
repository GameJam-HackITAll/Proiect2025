using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigation : MonoBehaviour
{
    [SerializeField] public GameObject mainMenuScreen;
    [SerializeField] public GameObject optionsScreen;
    // Start is called before the first frame update
    void Start()
    {
        mainMenuScreen.SetActive(true);
        optionsScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Debug.Log("Play");
        SceneManager.LoadScene("GameScene");
    }

    public void Options()
    {
        Debug.Log("Options");
        mainMenuScreen.SetActive(false);
        optionsScreen.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void MainMenu()
    {
        mainMenuScreen.SetActive(true);
        optionsScreen.SetActive(false);
    }
}
