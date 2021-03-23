using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from https://answers.unity.com/questions/994033/how-do-i-create-a-exitquit-button.html
public class ExitButton : MonoBehaviour
{ 
    public void doExitGame() {
        Application.Quit();
    }
}
