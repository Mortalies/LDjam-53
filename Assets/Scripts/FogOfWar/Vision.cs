using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    [SerializeField] private Transform maskCircle;
    [SerializeField] private Animator animator;
    private float radius;
    private float radiusInGrass;
    private void Awake()
    {
        //maskCircle.localScale = new Vector3(radius, radius, radius); 

    }
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter to grass");
        if (collision.GetComponent<Grass>() != null)
        {
            //maskCircle.localScale = new Vector3(radiusInGrass, radiusInGrass, radiusInGrass);
            animator.SetTrigger("In");
        }
            
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit the grass");
        if (collision.GetComponent<Grass>() != null)
        {
            //maskCircle.localScale = new Vector3(radius, radius, radius);
            animator.SetTrigger("Out");
        }
    }
}
