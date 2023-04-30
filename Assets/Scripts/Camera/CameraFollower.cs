using UnityEngine;

public class CameraFollower: MonoBehaviour
{
    [Min((0f))][SerializeField] private float _distance = 3f;
    [Range(0f,1f)] [SerializeField] private float _smoothTime = 0.125f;
    
    [SerializeField] private Player _player;
    
    private Vector3 velocity;

    private void Update()
    {
        var playerPosition = _player.transform.position + new Vector3(0f, 0f, -_distance);
        transform.position = Vector3.SmoothDamp(transform.position, playerPosition, ref velocity, _smoothTime);
    }
}
