using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool isPaused;
    public GameObject pauseMenu;
    // public GameObject OptionMenu;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        isPaused = false;
        pauseMenu.SetActive(false);

        //UpdateQualityLabel();
        // UpdateVolumeLabel();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("escape"))
        {
            isPaused = !isPaused;
            Time.timeScale = (isPaused) ? 0 : 1;
            pauseMenu.SetActive(isPaused);
        }
    }
    public void ResumeGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void hi()
    {
        Debug.Log("hi");
    }
}
