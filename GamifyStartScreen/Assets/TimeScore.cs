using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeScore : MonoBehaviour {
    public GameObject text;
    public float timeScore;
    public bool stopTime;
    public GameObject scoreObject;
    public float pointsScore;
    
    public float finalScore;

    public float maxMultiplier = 5;
    public float maxTime = 40;

    private float multiplier;

	// Use this for initialization
	void Start () {
        timeScore = 0;
        stopTime = false;
        //initialize the score from scoreObject somewhere here (pointsScore = scoreObject.GetComponent<scriptnaam>()."puntenscore")
        finalScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (!stopTime) {
            timeScore += Time.deltaTime;

            text.GetComponent<Text>().text = "Time: " + Mathf.RoundToInt(timeScore);
        } else 
        //Assign stopTime from another script to true when the game is over
        if (stopTime) {
            multiplier = timeScore / maxTime * maxMultiplier;
            finalScore =  multiplier * pointsScore;
            text.GetComponent<Text>().text = "Final score: " + Mathf.RoundToInt(finalScore);
        }
        if (Input.GetKeyDown(KeyCode.Space)) stopTime = true;
	}
}
