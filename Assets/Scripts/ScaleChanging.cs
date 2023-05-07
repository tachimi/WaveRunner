using UnityEngine;

public class ScaleChanging : MonoBehaviour
{
    [SerializeField] private Vector3 _finalScale;
    [SerializeField] private float _duration = 2f;
    
    private Vector3 _startScale;

    private float _currentTime;

    private void Start()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;

        transform.localScale = Vector3.Lerp(_startScale, _finalScale, progress);
    }
}