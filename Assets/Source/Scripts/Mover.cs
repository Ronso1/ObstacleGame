using UnityEngine;
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        var Horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        var Vertical = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(Horizontal * _speed, 0f, Vertical * _speed);
    }
}