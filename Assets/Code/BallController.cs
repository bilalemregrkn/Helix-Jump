using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private Vector2 velocityLimitMinMax;

    private void FixedUpdate()
    {
        var vertical = myRigidbody.velocity;
        vertical.y = Math.Clamp(vertical.y, velocityLimitMinMax.x, velocityLimitMinMax.y);
        myRigidbody.velocity = vertical;
    }
}