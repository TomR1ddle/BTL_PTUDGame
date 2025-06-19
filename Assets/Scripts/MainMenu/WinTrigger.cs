using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private GameObject winCanvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winCanvas.SetActive(true);
            Time.timeScale = 0f; // Dừng game khi thắng
        }
    }
}
