using System.Collections.Generic;
using App.Helpers;
using UnityEngine;

namespace App.MyCanvas
{
    public enum CanvasType
    {
        Home,
        GameOver,
        Successful
    }

    public class CanvasManager : Singleton<CanvasManager>
    {
        [SerializeField] private List<CanvasController> listCanvas;
        [SerializeField] private CanvasType startCanvas;

        private CanvasController _current;
        private readonly Stack<CanvasController> _history = new Stack<CanvasController>();

        private void Start()
        {
            Open(startCanvas);
        }

        public CanvasController GetCanvas(CanvasType type)
        {
            var result = listCanvas.Find(x => type == x.MyCanvasType());
            return result;
        }

        public void Open(CanvasType canvasType)
        {
            var canvas = listCanvas.Find(x => x.MyCanvasType() == canvasType);

            if (canvas == _current)
                return;

            if (_current)
            {
                _current.Close();
                _history.Push(_current);
            }


            if (!canvas) return;
            _current = canvas;
            _current.Open();
        }


        public void Back()
        {
            if (_history.Count == 0)
                return;

            _current.Close();

            var canvas = _history.Pop();
            _current = canvas;
            _current.Open();
        }
    }
}