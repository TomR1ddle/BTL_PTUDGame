using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private GameObject winCanvas;
    private AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioManager.StopBG();
            audioManager.PlaySFX(audioManager.winClip);
            winCanvas.SetActive(true);
            Time.timeScale = 0f; // Dừng game khi thắng
        }
    }
}
