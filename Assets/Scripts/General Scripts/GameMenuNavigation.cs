using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuNavigation : MonoBehaviour
{
    [SerializeField] public GameObject pauseScreen;
    [SerializeField] public GameObject optionsScreen;

    bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        pauseScreen.SetActive(false);
        optionsScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if (isPaused)
        {
            Debug.Log("Unpause");
            Time.timeScale = 1f;
            pauseScreen.SetActive(false);
            optionsScreen.SetActive(false);
            isPaused = false;
        }
        else
        {
            Debug.Log("Pause");
            Time.timeScale = 0f;
            pauseScreen.SetActive(true);
            optionsScreen.SetActive(false);
            isPaused = true;
        }
    }

    public void Options()
    {
        Debug.Log("Options");
        pauseScreen.SetActive(false);
        optionsScreen.SetActive(true);
    }

    public void MainMenu()
    {
        Debug.Log("MainMenu");
        FindFirstObjectByType<ScenePersist>().ResetScenePersist();
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void OptionsToPause()
    {
        Debug.Log("Pause");
        pauseScreen.SetActive(true);
        optionsScreen.SetActive(false);
    }
}