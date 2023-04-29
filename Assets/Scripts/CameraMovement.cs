using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private Transform _object;
    [SerializeField] private Vector3 _distanceFromObject;
    
    private void LateUpdate() 
    {
        Vector3 positionToGo = _object.position + _distanceFromObject; //Target position of the camera
        Vector3 smoothPosition = Vector3.Lerp(a: transform.position, b: positionToGo, t: 0.125F); 
        //Smooth position of the camera
        transform.position = smoothPosition;
        //transform.LookAt(_object.position);
    }
}
