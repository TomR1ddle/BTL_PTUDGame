using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("Canvas Prefabs")]
    public GameObject loseCanvasPrefab;
    public GameObject winCanvasPrefab;
    public GameObject pauseCanvasPrefab;

    [Header("Canvas Parent")]
    public Transform uiRoot; // Gán là một GameObject trống chứa các Canvas trong scene

    private GameObject currentLoseCanvas;
    private GameObject currentWinCanvas;
    private GameObject currentPauseCanvas;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ShowLose()
    {
        currentLoseCanvas = Instantiate(loseCanvasPrefab, uiRoot);
        Time.timeScale = 0f;
    }

    public void ShowWin()
    {
        if (currentWinCanvas != null)
        {
            Destroy(currentWinCanvas);
        }

        currentWinCanvas = Instantiate(winCanvasPrefab, uiRoot);
        Time.timeScale = 0f;
    }

    public void ShowPause()
    {
        if (currentPauseCanvas != null) return;

        currentPauseCanvas = Instantiate(pauseCanvasPrefab, uiRoot);
        Time.timeScale = 0f;
    }

    public void HidePause()
    {
        if (currentPauseCanvas != null)
        {
            Destroy(currentPauseCanvas);
            Time.timeScale = 1f;
        }
    }
}
