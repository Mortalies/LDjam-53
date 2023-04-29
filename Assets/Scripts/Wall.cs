using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private SpriteRenderer _sprite;
    void Start()
    {
        _sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    public void ChangeTransparency(int a)
    {
        var col = _sprite.color;
        col.a = a;
        _sprite.color = col;
    }
    void Update()
    {
        
    }
}
