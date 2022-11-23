using App.Helpers;
using App.MyCanvas;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 offset;

    private float startVertical;
    private CanvasHome home;

    private void Start()
    {
        offset = transform.position - target.position;

        startVertical = transform.position.y;
        home = (CanvasHome)CanvasManager.Instance.GetCanvas(CanvasType.Home);
    }

    private void LateUpdate()
    {
        var current = offset + target.position;

        if (current.y > transform.position.y)
            return;

        transform.position = current;

        var progress = Mathf.InverseLerp(startVertical, 0, transform.position.y);
        home.LevelProgressDisplay.Progress = progress;
    }
}