using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUi : MonoBehaviour
{
    public AudioSource click;

    public void OpenMenu()
    {
        click.Play();
        SceneManager.LoadScene("menu");
    } 
}
