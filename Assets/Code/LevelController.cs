using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static LevelController Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
}