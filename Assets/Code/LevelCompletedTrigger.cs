using UnityEngine;

public class LevelCompletedTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag($"Ball"))
        {
            GameManager.Instance.OnLevelCompleted();
        }
    }
}