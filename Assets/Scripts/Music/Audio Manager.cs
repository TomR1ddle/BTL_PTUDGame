using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;

    public AudioClip musicClip;
    public AudioClip enemyHitClip;
    public AudioClip playerHitClip;
    public AudioClip coinClip;
    public AudioClip winClip;
    public AudioClip loseClip;

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    void Start()
    {
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
    }

    public void StopBG()
    {
        musicAudioSource.Stop();
    }

    public void PlaySFX(AudioClip sfxClip)
    {
        vfxAudioSource.clip = sfxClip;
        vfxAudioSource.PlayOneShot(sfxClip);
    }
}
