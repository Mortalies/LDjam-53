using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInput : MonoBehaviour
{ 
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            DialogueController.instance.NextMessage();
            Debug.Log("Key F pressed");
        }
    }
}
