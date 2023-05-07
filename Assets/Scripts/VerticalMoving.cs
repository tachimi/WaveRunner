using UnityEngine;
using UnityEngine.Serialization;

public class VerticalMoving : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private float _upOffset = 2;
    [SerializeField] private float _downOffset = 2;

    private Vector3 _objectPosition;

    private float _currentTime;

    private void Start()
    {
        _objectPosition = transform.position;
    }

    public void Update()
    {
        _currentTime += Time.deltaTime;

        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;


        var newPosition = Vector3.Lerp(_objectPosition + (Vector3.up * _upOffset),
            _objectPosition + (Vector3.down * _downOffset), progress);

        transform.position = newPosition;
    }
}