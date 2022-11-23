using UnityEngine.SceneManagement;

namespace App.MyCanvas
{
    public class CanvasSuccessful : CanvasController
    {
        public override CanvasType MyCanvasType() => CanvasType.Successful;

        public void OnClick_LevelNext()
        {
            LevelManager.Instance.Level++;
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
    }
}