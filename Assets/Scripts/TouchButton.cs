//Bo-Chen Kuo authors
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; // Required when using Event data.
using UnityEngine.UI;

public class TouchButton : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (Input.touchCount >= 1) {
        }
    }

    //Do this when the mouse is clicked over the selectable object this script is attached to.
    public void OnPointerDown (PointerEventData eventData) {
        Debug.Log ("Update");
        Debug.Log (this.gameObject.name + " Was Clicked.");
    }

    //Do this when the mouse is clicked over the selectable object this script is attached to.
    public void OnPointerUp (PointerEventData eventData) {
        Debug.Log ("Update");
        Debug.Log (this.gameObject.name + " Was not Clicked.");
    }
}