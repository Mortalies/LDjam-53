using UnityEngine;


public class Grass : MonoBehaviour
{
    private SpriteRenderer _defualtSprite;

    public void ChangeTransparency()
    {
        _defualtSprite.color = new Color(_defualtSprite.color.r, _defualtSprite.color.g, _defualtSprite.color.b, 0f);
    }
    
    public void SetDefualtTransparency()
    {
        _defualtSprite.color = new Color(_defualtSprite.color.r, _defualtSprite.color.g, _defualtSprite.color.b, 1f);
    }
    
    private void Awake()
    {
        _defualtSprite = GetComponent<SpriteRenderer>();
    }
}
