using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource click;

    public void Play()
    {
        click.Play();
        SceneManager.LoadScene("Bounce_back");
    }

    public void Exit()
    {
        click.Play();
        Application.Quit();
    }
}
