using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnoFXControl : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip carnoRoar;

    public void CarnoRoar()
    {
        audioSource.PlayOneShot(carnoRoar);
    }
}
