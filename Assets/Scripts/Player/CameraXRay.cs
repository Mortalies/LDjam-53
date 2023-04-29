using System;
using Unity.VisualScripting;
using UnityEngine;

public class CameraXRay: MonoBehaviour
{
    [Range(0f,0.1f)] [SerializeField] private float _transparencySpeed;
    
    [SerializeField] private Player _player;

    private void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, (_player.transform.position - transform.position).normalized);
        Physics.Raycast(ray, out hit, Mathf.Infinity);
        hit.collider.gameObject.Route<Wall>(wall => wall.ChangeTransparency());
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, (_player.transform.position - transform.position).normalized);
    }
}
