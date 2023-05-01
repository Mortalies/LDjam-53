using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    [SerializeField] private Transform maskCircle;
    [SerializeField] private float radius;
    [SerializeField] private float radiusInGrass;
    private void Awake()
    {
        maskCircle.localScale = new Vector3(radius, radius, radius); 

    }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Grass>() != null)
        {
            maskCircle.localScale = new Vector3(radiusInGrass, radiusInGrass, radiusInGrass);
        }
            
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Grass>() != null)
        {
            maskCircle.localScale = new Vector3(radius, radius, radius);
        }
    }
}
