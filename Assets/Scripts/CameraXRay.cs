using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class CameraXRay : MonoBehaviour
{
    [SerializeField] private Transform _plr;
    List<Wall> walls;

    void FixedUpdate()
    {
        if (walls != null)
        {
            foreach (Wall wal in walls)
            {
                wal.ChangeTransparency(255);
            }
            walls.Clear();
        }
        RaycastHit hit;
        Ray ray = new Ray(transform.position, (_plr.position - transform.position).normalized);
        Physics.Raycast(ray, out hit, Mathf.Infinity);
        if(hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.name);
            if(hit.collider.GetComponent<Wall>())
            {
                Wall wall = hit.collider.GetComponent<Wall>();
                wall.ChangeTransparency(160);
                walls.Add(wall);
            }
        }
        Debug.DrawLine(ray.origin, hit.point, Color.red);
    }
}
