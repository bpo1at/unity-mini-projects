using UnityEngine;
using UnityEngine.InputSystem;

public class GameOverUI : MonoBehaviour
{
    public GameObject panelOrText;

    void Awake()
    {
        if (panelOrText != null)
            panelOrText.SetActive(false);
    }

    void Update()
    {
        bool gameOver = GameManager.Instance != null && GameManager.Instance.IsGameOver;

        if (panelOrText != null)
            panelOrText.SetActive(gameOver);

        if (gameOver && Keyboard.current != null && Keyboard.current.rKey.wasPressedThisFrame)
        {
            GameManager.Instance.Restart();
        }
    }
}
