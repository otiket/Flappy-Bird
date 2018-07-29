﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour {

    public Text resultText;
	// Use this for initialization
	void Start () {
        resultText.text = "Game Over...\nYour score is " + ScoreManager.score + "\nPush Space Key.";
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
	}
}
