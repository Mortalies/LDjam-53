using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wall : MonoBehaviour
{
    private SpriteRenderer _defualtSprite;

    public void ChangeTransparency()
    {
        var transparencyColor =  new Color(_defualtSprite.color.r, _defualtSprite.color.g, _defualtSprite.color.b, 0f);
        _defualtSprite.color = Color.Lerp(_defualtSprite.color, transparencyColor, Time.deltaTime);
    }
    
    public void SetDefualtTransparency()
    {
        var transparencyColor =  new Color(_defualtSprite.color.r, _defualtSprite.color.g, _defualtSprite.color.b, 1f);
        _defualtSprite.color = Color.Lerp(_defualtSprite.color, transparencyColor, Time.deltaTime);
    }
    
    private void Awake()
    {
        _defualtSprite = GetComponent<SpriteRenderer>();
    }
}
