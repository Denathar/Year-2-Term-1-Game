using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static bool IsPaused;

    public GameObject StartScreen;
    public GameObject PauseScreen;
    public GameObject DeathScreen;
    public GameObject VictoryScreen;
    public GameObject PlayerGui;

    public GameObject Player;
    public GameObject PlayerCamera;
    public GameObject StartCamera;

    bool PauseOn = false;

    private void Start()
    {
        StartScreen.SetActive(true);
        StartCamera.SetActive(true);

        if (PauseScreen != null)
        {
            PauseScreen.SetActive(false);
        }

        if (DeathScreen != null)
        {
            DeathScreen.SetActive(false);
        }
        VictoryScreen.SetActive(false);
        PlayerGui.SetActive(false);
        PlayerCamera.SetActive(false);
        Player.SetActive(false);

    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            PauseOn = !PauseOn;
        }

        if (PauseOn == true)
        {
            PauseActive();
        }
        if (PauseOn == false)
        {
            PauseInActive();
        }

        if (StartScreen.activeSelf == true)
        {
            PauseScreen.SetActive(false);
            PauseOn = false;
        }

        if (Player.activeSelf == false)
        {
            if (StartScreen.activeSelf == false)
            {
                PlayerGui.SetActive(false);
                DeathScreen.SetActive(true);
            }
            
        }

    }

    public void OnStartPressed()
    {
        //Enter code here to start the game

        Debug.Log("START GAME");

        Player.SetActive(true);
        PlayerCamera.SetActive(true);
        PlayerGui.SetActive(true);
        StartCamera.SetActive(false);
        StartScreen.SetActive(false);

        
    }

    public void OnPressed()
    {
        Debug.Log("pressed");
    }

    public void PauseUI()
    {
        PauseOn = true;
        PauseActive();
    }
    public void PauseActive()
    {
        PauseScreen.SetActive(true);
        Time.timeScale = 0.0F;
        PlayerGui.SetActive(false);
        Player.GetComponent<PlayerMovmentNew>().enabled = false;
        
    }
    public void PauseInActive()
    {
        PauseOn = false;
        PauseScreen.SetActive(false);
        Time.timeScale = 1F;
        Player.GetComponent<PlayerMovmentNew>().enabled = true;
        if (StartScreen.activeSelf == false)
        {
            PlayerGui.SetActive(true);
        }
        //Debug.Log("Pause off");
        

    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level !");

    }


}
