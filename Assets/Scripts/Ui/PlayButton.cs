using Assets.Scripts.Ui;
using UnityEngine.SceneManagement;

public class PlayButton : AbstractButton
{
    public override void OnButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
