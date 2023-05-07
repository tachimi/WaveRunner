using UnityEngine;

public class Rotating : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    public void Update()
    {
        transform.Rotate(Vector3.back, _rotationSpeed * Time.deltaTime, Space.Self);
    }
}