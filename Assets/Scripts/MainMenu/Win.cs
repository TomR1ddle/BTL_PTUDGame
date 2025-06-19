using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Win : MonoBehaviour
{
    [SerializeField] GameObject winMenu;
    public void LoseMenu()
    {
        winMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
