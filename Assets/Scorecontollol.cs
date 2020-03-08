﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorecontollol : MonoBehaviour {
    
    private int score;
    public Text scoreText;

    void OnCollisionEnter(Collision collision)
    {


        //衝突判定
        if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 30;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 40;
        }


        SetScore();
    }

    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
