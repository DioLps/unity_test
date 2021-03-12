using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class RightMoveHandler :   MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private bool isPressed = false;
    public GameObject player;
    public float speed;
    public AudioSource click;

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            if (!player)
            {
                return;
            }
            player.transform.Translate(speed * Time.deltaTime, 0f, 0f); 
            if (player.transform.position.x > 7)
            {
                OnLimitBorders();
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        click.Play();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

    private void OnLimitBorders()
    {
        Destroy(player);
        SceneManager.LoadScene("GameOver");
    }
}
