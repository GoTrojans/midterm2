using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // need this namespace to access type: "Text"

public class ScoreBoard : MonoBehaviour {

    int score;
    Text scoreText;

	// Use this for initialization
	void Start () {
        scoreText = GetComponent<Text>(); // Give us a reference of the whole text component
        scoreText.text = score.ToString();
	}

    public void ScoreHit(int scorePerHit)
    {
        // I have added code
        // Change C
        score = score + scorePerHit;
        scoreText.text = score.ToString();
    }
}
