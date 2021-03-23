//Bo-Chen Kuo authors
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

    public Text scoreNumberText;
    private static int score;
    // Start is called before the first frame update
    void Start () {
        score = 0;
    }

    void OnTriggerEnter (Collider collider) {
        if (collider.gameObject.GetComponent<BowlingPin> () != null) {
            if (collider.gameObject.GetComponent<BowlingPin> ().getTouchGoal () == false) {
                score++;
                //Debug.Log(score);
            }
            collider.gameObject.GetComponent<BowlingPin> ().setTouchGoal (true);
            scoreNumberText.text = "" + score;
        }
    }

    public void reset () {
        score = 0;
    }
}