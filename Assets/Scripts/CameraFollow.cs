using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _objectToFollow = null;

    [SerializeField] private Vector2 _maxOffset = Vector2.zero;
    [SerializeField] private float _followSpeed = 1.0f;
    [SerializeField] private AnimationCurve _speedFactorFromOffset = null;

    private void Update()
    {
        // On Calcule l'offset entre la position de la camera et de l'objet a suivre
        float xOffset = transform.position.x - _objectToFollow.transform.position.x;
        // On garde en memoire le signe de l'offset
        float offsetSign = Mathf.Sign(xOffset);

        float speed = _followSpeed * _speedFactorFromOffset.Evaluate(xOffset * offsetSign) * Time.deltaTime;

        float newOffsetX = xOffset + speed * offsetSign;
        
        newOffsetX = Mathf.Clamp(newOffsetX, -_maxOffset.x, _maxOffset.y);

        float newPositionX = _objectToFollow.transform.position.x + newOffsetX;

        Vector3 newPosition = transform.position;
        newPosition.x = newPositionX;
        transform.position = newPosition;

    }

}
