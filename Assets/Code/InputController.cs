using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    [SerializeField] private float speed;
    
    public void OnDrag(PointerEventData eventData)
    {
        var main = LevelController.Instance.transform;
        var rotation = main.rotation;
        var current = rotation.eulerAngles.y;
        current += eventData.delta.x * speed;
        rotation.eulerAngles = new Vector3(0, current, 0);

        main.rotation = rotation;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        GameManager.Instance.OnGameStart();
    }
}