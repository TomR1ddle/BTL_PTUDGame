using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    const string TOWN_TEXT = "Scene1";

    public void PauseButton()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");

    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);

    }

    public void Restart()
    {
        Time.timeScale = 1;
        StartCoroutine(DeathLoadSceneRoutine());

    }

    private IEnumerator DeathLoadSceneRoutine()
    {
        yield return new WaitForSecondsRealtime(.5f);
        Destroy(gameObject);
        SceneManager.LoadScene(TOWN_TEXT);
    }
}
