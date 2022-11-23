using App.MyAudio;
using UnityEngine;

namespace App.MyCanvas
{
    [RequireComponent(typeof(Canvas))]
    public abstract class CanvasController : MonoBehaviour
    {
        public virtual CanvasType MyCanvasType() => CanvasType.Home;
        private Canvas _canvas;
        private AudioController audioController;

        private void Awake()
        {
            _canvas = GetComponent<Canvas>();
            audioController = GetComponent<AudioController>();
        }

        public virtual void Open()
        {
            if (audioController) audioController.Play();
            _canvas.enabled = true;
        }

        public virtual void Close()
        {
            _canvas.enabled = false;
        }
    }
}