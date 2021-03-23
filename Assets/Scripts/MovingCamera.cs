//Bo-Chen Kuo authors
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour {
    public GameObject ball;
    public float displacement = 10;
    public float turnningSpeed = 1;

    private Rigidbody rb;
    private float cameraAngle;
    private bool left;
    private bool right;

    // Start is called before the first frame update
    void Start () {
        rb = ball.GetComponent<Rigidbody> ();
        left = false;
        right = false;
        faceAngle (0);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetAxis ("Horizontal") > 0) {
            cameraAngle += turnningSpeed;
        } else if (Input.GetAxis ("Horizontal") < 0) {
            cameraAngle -= turnningSpeed;
        }

        if (right) {
            cameraAngle += turnningSpeed;
        } else if (left) {
            cameraAngle -= turnningSpeed;
        }

        faceAngle (cameraAngle);
    }

    public void setLeft (bool left) {
        this.left = left;
    }

    public void setRight (bool right) {
        this.right = right;
    }

    void faceAngle (float angle) {
        //adjust displacement
        transform.position = ball.transform.position;
        transform.position += new Vector3 ((float) Math.Sin (angle * Math.PI / 180f) * -displacement, 11.5f, (float) Math.Cos (angle * Math.PI / 180f) * -displacement);
        //adjust angle
        transform.rotation = Quaternion.Euler (35, angle, 0);
    }

    public void reset () {
        cameraAngle = 0;
    }
}