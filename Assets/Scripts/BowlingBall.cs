//Bo-Chen Kuo authors
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//some part refer to https://www.youtube.com/watch?v=hyBOdoir-Cg

public class BowlingBall : MonoBehaviour {
    private Rigidbody rb;
    private float str_x, str_y, str_z;
    private bool forward;
    private bool backward;

    public GameObject mycamera;
    public float force = 2f;
    public float friction = -0.1f;
    public float speedLimit = 30;

    // Start is called before the first frame update
    void Start () {
        str_x = transform.localPosition.x;
        str_y = transform.localPosition.y;
        str_z = transform.localPosition.z;
        rb = GetComponent<Rigidbody> ();
        forward = false;
        backward = false;
    }

    // Update is called once per frame
    void FixedUpdate () {

        if (Input.GetAxis ("Vertical") > 0) {
            moveForward ();
        } else if (Input.GetAxis ("Vertical") < 0) {
            moveBackward ();
        } else if (rb.velocity.magnitude > 0) {
            rb.AddForce (rb.velocity.normalized * friction);
        }

        if (forward) {
            moveForward ();
        } else if (backward) {
            moveBackward ();
        }

        if (rb.velocity.magnitude <= 0.1) {
            rb.velocity = new Vector3 (0, 0, 0);
            rb.angularVelocity = new Vector3 (0, 0, 0);
        }

        if (transform.position.y < -1) {
            reset ();
            mycamera.GetComponent<MovingCamera> ().reset ();
        }
    }

    public void setForward (bool forward) {
        this.forward = forward;
    }

    public void setBackward (bool backward) {
        this.backward = backward;
    }

    public void moveForward () {
        Vector3 direction = transform.position - mycamera.transform.position;
        direction.y = 0;
        if (rb.velocity.magnitude < speedLimit) {
            rb.AddForce (direction.normalized * force);
        }
    }

    public void moveBackward () {
        Vector3 direction = transform.position - mycamera.transform.position;
        direction.y = 0;
        if (rb.velocity.magnitude < speedLimit) {
            rb.AddForce (direction.normalized * -force);
        }
    }

    public void reset () {
        transform.localPosition = new Vector3 (str_x, str_y, str_z);
        transform.localRotation = Quaternion.identity;
        rb.velocity = new Vector3 (0, 0, 0);
        rb.angularVelocity = new Vector3 (0, 0, 0);
    }
}