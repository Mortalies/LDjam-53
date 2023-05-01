using UnityEngine;

public class EventHandler : MonoBehaviour
{
    [SerializeField] private PlayerSpawner _spawner;
    [SerializeField] private CameraFollower _camera;

    private void OnEnable()
    {
        _spawner.OnPlayerSpawned += _camera.Initialize;
    }

    private void OnDisable()
    {
        _spawner.OnPlayerSpawned -= _camera.Initialize;
    }
}
