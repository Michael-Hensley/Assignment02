using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuNavigation : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void toMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void toSettings()
    {
        SceneManager.LoadScene(1);
    }

    public void quitApp()
    {
        Application.Quit();
    }
}
