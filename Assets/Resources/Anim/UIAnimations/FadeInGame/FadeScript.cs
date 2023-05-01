using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{
    
    public void End()
    {
        GameStart.instance.EndScene();
    }
}
