using UnityEngine.SceneManagement;

namespace App.MyCanvas
{
	public class CanvasGameOver : CanvasController
	{
		public override CanvasType MyCanvasType() => CanvasType.GameOver;
		
		public void OnClick_TryAgain()
		{
			SceneManager.LoadScene(sceneBuildIndex: 0);
		}
		
	}
}