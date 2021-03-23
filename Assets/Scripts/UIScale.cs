//Bo-Chen Kuo authors
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScale : MonoBehaviour {
    public float dispalcementX = -0.33f;
    public float dispalcementY = 0.33f;
    public float scale = 1f;

    // Start is called before the first frame update
    void Start () {
        setScale ();
    }

    // Update is called once per frame
    void Update () {
        setScale ();
    }

    void setScale () {
        transform.localPosition = new Vector3 (Screen.width * dispalcementX, Screen.height * dispalcementY, 0);
        transform.localScale = new Vector3 (min (Screen.width / 1920f * scale, Screen.height / 1080f * scale), min (Screen.width / 1920f * scale, Screen.height / 1080f * scale), 1);
    }

    float min (float a, float b) {
        return a < b ? a : b;
    }
}