using UnityEngine;

public class HorizontalMoving : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private float _leftOffset = 2;
    [SerializeField] private float _rightOffset = 2;
    
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


        var newPosition = Vector3.Lerp(_objectPosition + (Vector3.left * _leftOffset),
            _objectPosition + (Vector3.right * _rightOffset), progress);

        transform.position = newPosition;
    }
}