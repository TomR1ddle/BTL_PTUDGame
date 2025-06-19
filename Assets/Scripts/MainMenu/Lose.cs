using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    [SerializeField] GameObject loseMenu;
    public void LoseMenu()
    {
        loseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
