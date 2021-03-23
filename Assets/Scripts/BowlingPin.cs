//Bo-Chen Kuo authors
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
//all original
public class BowlingPin : MonoBehaviour {
    private Rigidbody rb;
    public GameObject goal;
    private float str_x, str_y, str_z;

    private bool touch_goal = false;
    //AudioSource audioSource;

    void Start () {
        str_x = transform.localPosition.x;
        str_y = transform.localPosition.y;
        str_z = transform.localPosition.z;
        rb = GetComponent<Rigidbody> ();
        //audioSource = GetComponent<AudioSource>();
    }

    public void setTouchGoal (bool isTouch) {
        touch_goal = isTouch;
    }

    public bool getTouchGoal () {
        return touch_goal;
    }

    public void reset () {
        touch_goal = false;
        transform.localPosition = new Vector3 (str_x, str_y, str_z);
        transform.localRotation = Quaternion.identity;
        rb.velocity = new Vector3 (0, 0, 0);
        rb.angularVelocity = new Vector3 (0, 0, 0);
    }
}