using UnityEngine;
public class Dropper : MonoBehaviour
{
    [SerializeField] private float _timeForWait = 3f;
    [SerializeField] private MeshRenderer _renderer;
    [SerializeField] private Rigidbody _cubeRB;
    private void Start()
    {
        _renderer.enabled = false;
        _cubeRB.useGravity = false;
    }
    private void Update()
    {
        if (Time.time > _timeForWait)
        {
            _renderer.enabled = true;
            _cubeRB.useGravity = true;
        }
    }
}