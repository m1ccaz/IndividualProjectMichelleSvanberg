using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public SceneFader fader; // lägg till denna rad

    public void StartWalk()
    {
        fader.FadeToScene("Walk");
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("App closed!");
    }
}