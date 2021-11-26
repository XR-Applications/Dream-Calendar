using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientMusicManager : MonoBehaviour
{
    public AudioClip buttonFX;
    private AudioSource audioSource;

    private static AmbientMusicManager instance;
    public static AmbientMusicManager Instance
    {
        get => instance;
    }
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayButtonPressFX()
    {
        audioSource.PlayOneShot(buttonFX);
    }
}
