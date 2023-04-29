using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmoothPosition : MonoBehaviour
{
    public Vector3 SmoothMovement(Vector3 camPosition)
    {
        var smoothPosition = Vector3.Lerp(a: transform.position, b: camPosition, t: 0.125F);
        return smoothPosition;
    }
}
