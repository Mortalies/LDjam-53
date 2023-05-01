using UnityEngine;

public class CameraFollower: MonoBehaviour
{
<<<<<<< Updated upstream
    [Min((0f))][SerializeField] private float _distance = 5f; 
=======
    [Min((0f))][SerializeField] private float _distance = 3f;
>>>>>>> Stashed changes
    private float _smoothTime = 0.125f;
    
    private Player _player;
    
    private Vector3 velocity;

    public void Initialize(Player player)
    {
        _player = player;
    }
    
    private void Update()
    {
        var playerPosition = _player.transform.position + new Vector3(0f, 0f, -_distance);
        transform.position = Vector3.SmoothDamp(transform.position, playerPosition, ref velocity, _smoothTime);
    }
}
