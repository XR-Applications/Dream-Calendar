using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinoSaurFXControl : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip spinoRoar;

    public void SpinoRoar()
    {
        audioSource.PlayOneShot(spinoRoar);
    }
}
