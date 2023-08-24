using UnityEngine;
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private GameInformation _gameInformation = new GameInformation();
    private void Start() => _gameInformation.PrintInformation();
    private void Update() => PlayerMovement();
    private void PlayerMovement()
    {
        var Horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        var Vertical = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(Horizontal * _speed, 0f, Vertical * _speed);
    }
}