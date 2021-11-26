using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrexFxControl : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip trexRoar;

    public void TrexRoar()
    {
        audioSource.PlayOneShot(trexRoar);
    }
}
