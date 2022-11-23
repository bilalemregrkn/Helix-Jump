using UnityEngine;
using UnityEngine.UI;

public class LevelProgressDisplay : MonoBehaviour
{
    public float Progress
    {
        get => _progress;
        set
        {
            _progress = value;
            imageFill.fillAmount = _progress;
        }
    }

    private float _progress;

    [SerializeField] private Image imageFill;
}