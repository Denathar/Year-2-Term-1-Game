using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static bool IsPaused;

    public GameObject StartScreen;
<<<<<<< HEAD
    public GameObject StartCamera;
=======
>>>>>>> master
    public GameObject PauseScreen;
    public GameObject DeathScreen;
    public GameObject VictoryScreen;
    public GameObject PlayerGui;
<<<<<<< HEAD
    public GameObject Player;
    public GameObject PlayerCamera;
    
=======

    public GameObject Player;
    public GameObject PlayerCamera;
    public GameObject StartCamera;
>>>>>>> master

    bool PauseOn = false;

    private void Start()
    {
<<<<<<< HEAD
        if (StartScreen != null)
        {
            StartScreen.SetActive(true);
        }
        if (StartCamera != null)
        {
            StartCamera.SetActive(true);
        }
=======
        StartScreen.SetActive(true);
        StartCamera.SetActive(true);

>>>>>>> master
        if (PauseScreen != null)
        {
            PauseScreen.SetActive(false);
        }
<<<<<<< HEAD
=======

>>>>>>> master
        if (DeathScreen != null)
        {
            DeathScreen.SetActive(false);
        }
<<<<<<< HEAD
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
=======
        VictoryScreen.SetActive(false);
        PlayerGui.SetActive(false);
        PlayerCamera.SetActive(false);
        Player.SetActive(false);

>>>>>>> master
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            PauseOn = !PauseOn;
        }
<<<<<<< HEAD
=======

>>>>>>> master
        if (PauseOn == true)
        {
            PauseActive();
        }
        if (PauseOn == false)
        {
            PauseInActive();
        }
<<<<<<< HEAD
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
                if (StartScreen != null)
                {
                    if (StartScreen.activeSelf == false)
                    {
                        PlayerGui.SetActive(false);
                        DeathScreen.SetActive(true);
                    }
                }
                
            }
        }
=======

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

>>>>>>> master
    }

    public void OnStartPressed()
    {
        //Enter code here to start the game
<<<<<<< HEAD
        SceneManager.LoadScene("Level !");
        //Debug.Log("START GAME");

        //Player.SetActive(true);
        //PlayerCamera.SetActive(true);
        //PlayerGui.SetActive(true);
        //StartCamera.SetActive(false);
        //StartScreen.SetActive(false);

        
    }
=======

        Debug.Log("START GAME");

        Player.SetActive(true);
        PlayerCamera.SetActive(true);
        PlayerGui.SetActive(true);
        StartCamera.SetActive(false);
        StartScreen.SetActive(false);

        
    }

>>>>>>> master
    public void OnPressed()
    {
        Debug.Log("pressed");
    }
<<<<<<< HEAD
=======

>>>>>>> master
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
<<<<<<< HEAD
        if (PauseScreen != null)
        {
            PauseScreen.SetActive(false);
        }
        Time.timeScale = 1F;
        if (Player != null)
        {
            Player.GetComponent<PlayerMovmentNew>().enabled = true;
        }
        if (StartScreen != null)
        {
            if (StartScreen.activeSelf == false)
            {
                PlayerGui.SetActive(true);
            }
        }
        
    }
=======
        PauseScreen.SetActive(false);
        Time.timeScale = 1F;
        Player.GetComponent<PlayerMovmentNew>().enabled = true;
        if (StartScreen.activeSelf == false)
        {
            PlayerGui.SetActive(true);
        }
        //Debug.Log("Pause off");
        

    }

>>>>>>> master
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
<<<<<<< HEAD
=======

>>>>>>> master
    public void Restart()
    {
        SceneManager.LoadScene("Level !");

    }
<<<<<<< HEAD
=======


>>>>>>> master
}
