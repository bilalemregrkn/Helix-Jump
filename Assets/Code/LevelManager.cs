using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private List<LevelController> list;

    public static LevelManager Instance { get; private set; }
    public int Level { get; set; }

    public void CreateLevel(int level)
    {
        var prefab = list[level];
        GameObject.Instantiate(prefab);
    }

    public void CreateLevel()
    {
        CreateLevel(Level);
    }

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}