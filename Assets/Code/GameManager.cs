using App.MyCanvas;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1;
        LevelManager.Instance.CreateLevel();
    }

    public void OnGameStart()
    {
        var home = (CanvasHome)CanvasManager.Instance.GetCanvas(CanvasType.Home);
        home.TextStart.enabled = false;
    }

    public void OnGameOver()
    {
        CanvasManager.Instance.Open(CanvasType.GameOver);
        Time.timeScale = 0;
    }

    public void OnLevelCompleted()
    {
        CanvasManager.Instance.Open(CanvasType.Successful);
    }
}