using System;
using App.MyAudio;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private Vector2 velocityLimitMinMax;
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private ShakeableTransform shakeable;
    [SerializeField] private float shake;
    [SerializeField] private AudioController audioController;

    private void FixedUpdate()
    {
        var vertical = myRigidbody.velocity;
        vertical.y = Math.Clamp(vertical.y, velocityLimitMinMax.x, velocityLimitMinMax.y);
        myRigidbody.velocity = vertical;
    }

    private void OnCollisionEnter(Collision collision)
    {
        particle.Play();
        shakeable.InduceStress(shake);
        audioController.Play();
    }
}