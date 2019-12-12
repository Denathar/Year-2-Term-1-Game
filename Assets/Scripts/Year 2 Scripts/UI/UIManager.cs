﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static bool IsPaused;

    public GameObject StartScreen;
    public GameObject StartCamera;
    public GameObject PauseScreen;
    public GameObject DeathScreen;
    public GameObject VictoryScreen;
    public GameObject PlayerGui;
    public GameObject Player;
    public GameObject PlayerCamera;
    

    bool PauseOn = false;

    private void Start()
    {
        if (StartScreen != null)
        {
            StartScreen.SetActive(true);
        }
        if (StartCamera != null)
        {
            StartCamera.SetActive(true);
        }
        if (PauseScreen != null)
        {
            PauseScreen.SetActive(false);
        }
        if (DeathScreen != null)
        {
            DeathScreen.SetActive(false);
        }
        if (VictoryScreen != null)
        {
            VictoryScreen.SetActive(false);
        }
        if (PlayerGui != null)
        {
            PlayerGui.SetActive(false);
        }
        if (PlayerCamera != null)
        {
            PlayerCamera.SetActive(false);
        }
        if (Player != null)
        {
            Player.SetActive(false);
        }

        if (StartScreen == null)
        {
            if (PlayerCamera != null)
            {
                PlayerCamera.SetActive(true);
            }
            if (Player != null)
            {
                Player.SetActive(true);
            }
            if (PlayerGui != null)
            {
                PlayerGui.SetActive(true);
            }
        }
    }

    public void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            PauseOn = !PauseOn;
        }
        if (PauseOn == true)
        {
            PauseActive();
        }
        if (VictoryScreen != null)
        {
            if (VictoryScreen.activeSelf == false)
            {
                if (PauseOn == false)
                {
                    PauseInActive();
                }
            }
        }
        if (StartScreen != null)
        {
            if (StartScreen.activeSelf == true)
            {
                if (PauseScreen != null)
                {
                    PauseScreen.SetActive(false);
                }
                PauseOn = false;
            }
        }

        if (Player != null)
        {
            if (Player.activeSelf == false)
            {
                PlayerGui.SetActive(false);
                DeathScreen.SetActive(true); 
            }
        }
        if (VictoryScreen != null)
        {
            if (VictoryScreen.activeSelf == true)
            {
                PlayerGui.SetActive(false);
            }
        }

    }

    public void OnStartPressed()
    {
        //Enter code here to start the game
        SceneManager.LoadScene("Level !");
        //Debug.Log("START GAME");

        //Player.SetActive(true);
        //PlayerCamera.SetActive(true);
        //PlayerGui.SetActive(true);
        //StartCamera.SetActive(false);
        //StartScreen.SetActive(false);

        
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
        if (PauseScreen != null)
        {
            PauseScreen.SetActive(false);
        }
        Time.timeScale = 1F;
        if (Player != null)
        {
            Player.GetComponent<PlayerMovmentNew>().enabled = true;
        }
        if (PlayerGui != null)
        {
            PlayerGui.SetActive(true);
        }

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
    public void Menu()
    {
        SceneManager.LoadScene("Main Menu Scene");

    }
}