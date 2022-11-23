using System;
using TMPro;
using UnityEngine;

namespace App.MyCanvas
{
    public class CanvasHome : CanvasController
    {
        public override CanvasType MyCanvasType() => CanvasType.Home;

        public TextMeshProUGUI TextStart => textStart;
        [SerializeField] private TextMeshProUGUI textStart;
        [SerializeField] private TextMeshProUGUI textLevel;
        public LevelProgressDisplay LevelProgressDisplay => levelProgressDisplay;
        [SerializeField] private LevelProgressDisplay levelProgressDisplay;

        public void OnClick_Next()
        {
            CanvasManager.Instance.Open(CanvasType.GameOver);
        }

        private void Start()
        {
            textLevel.SetText($"LEVEL {LevelManager.Instance.Level + 1}");
        }
    }
}