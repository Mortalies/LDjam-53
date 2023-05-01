using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    [SerializeField] private Transform maskCircle;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private float _slow;
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
            _playerMovement.SlowMoveSpeed(_slow);
        }
            
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Grass>() != null)
        {
            maskCircle.localScale = new Vector3(radius, radius, radius);
            _playerMovement.SetToDefualt(_slow);
        }
    }
}
