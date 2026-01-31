using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public bool IsGameOver { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        // DontDestroyOnLoad(gameObject); // tek sahnede kalacaksan gerek yok
    }

    public void GameOver()
    {
        if (IsGameOver) return;
        IsGameOver = true;

        // Oyun dursun (en basit yöntem)
        Time.timeScale = 0f;

        Debug.Log("GAME OVER");
    }

    public void Restart()
    {
        Time.timeScale = 1f;

        // Mevcut aktif sahneyi yeniden yükle
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
