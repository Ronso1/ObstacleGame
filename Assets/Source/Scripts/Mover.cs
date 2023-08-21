using UnityEngine;
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        var Horizontal = Input.GetAxis("Horizontal");
        var Vertical = Input.GetAxis("Vertical");
        transform.Translate(Horizontal * _speed * Time.deltaTime, 0f, Vertical * _speed * Time.deltaTime);
    }
}