using UnityEngine;
public class Spinner : MonoBehaviour
{
    [SerializeField] private float _xAngle, _yAngle, _zAngle;
    private void Update()
    {
        transform.Rotate(_xAngle, _yAngle, _zAngle);
    }
}