﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject player;

    public GameObject MainMenuCamera;
    public GameObject camera1;

    public GameObject MMUI;

    public GameObject TreeLifeUI;


    void Start()
    {
        TreeLifeUI.SetActive(false);
        camera1.active = false;
        MainMenuCamera.active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (MainMenuCamera.active)
        {
            MMUI.SetActive(true);
            player.GetComponent<playerMovement>().enabled = false;

        }

        if (camera1.active)
        {
            MMUI.SetActive(false);
            player.GetComponent<playerMovement>().enabled = true;
        }
       
    }

    public void PlayGame()
    {
        MainMenuCamera.active = false;
        camera1.active = true;
        TreeLifeUI.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
