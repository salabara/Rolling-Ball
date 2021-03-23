//Bo-Chen Kuo authors
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//all original
public class ResetButton : MonoBehaviour
{
    public Text score;
    public GameObject bowlingPinsSet;
    public GameObject bowlingBall;
    public GameObject goal;
    public GameObject mycamera;
    private int count = 0;

    public void restGame( ){        
        count++;
        foreach(BowlingPin bp in bowlingPinsSet.GetComponentsInChildren<BowlingPin>()){
            bp.reset();
        }
        bowlingBall.GetComponent<BowlingBall>().reset();
        goal.GetComponent<Goal>().reset();
        mycamera.GetComponent<MovingCamera>().reset();
        score.text = "0";
    }
}
