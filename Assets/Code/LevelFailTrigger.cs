using System;
using UnityEngine;

public class LevelFailTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag($"Ball"))
        {
            GameManager.Instance.OnGameOver();
        }
    }
}