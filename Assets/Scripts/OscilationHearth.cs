using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscilationHearth : MonoBehaviour
{
    [SerializeField] private float _oscilationAmplitude = 0.0f;
    [SerializeField] private float _oscilationFrequency = 0.0f;

    [SerializeField] private float _rotationSpeed = 0.0f;
    [SerializeField] private AnimationCurve _rotationCurve = null;

    Vector3 _basePosition = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        _basePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float osci = Mathf.Sin(Time.time * _oscilationFrequency) * _oscilationAmplitude ;
        osci = (osci + 1.0f) / 2.0f;
        osci *= _oscilationAmplitude;

        transform.position = _basePosition + new Vector3(0.0f,osci,0.0f);
    }
}
