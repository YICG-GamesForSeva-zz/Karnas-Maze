/*
 * Young Indian Culture Group Inc. 5013(c)
 * 
 * Copyright (c) 2017
 * 
 * Author       :   Pranav S. Krishnamurthy; Japesh Shah
 * 
 * Project      :   Karna's Maze
 * 
 * File Name    :   GameDescriptionBehavior.cs
 * 
 * Date Created :   30th August 2017
 * 
 * Purpose      :   This script will be able to have all of the UI functionality to determine the transition
 *                  from the game description to the actual game called "Game"
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehavior : MonoBehaviour {

	public void progressTrigger(int trig)
    {
        switch (trig)
        {
            case (0):
                SceneManager.LoadScene("Game"); 
                break;
            default:
                break;
        }
    }
}