using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXControl : MonoBehaviour
{
    [SerializeField] AudioSource audiosource;
    [SerializeField] AudioClip dinoRoar;
    [SerializeField] AudioClip[] shipWhoosh;
    int randomIndex;

    private void Start()
    {
        randomIndex = Random.Range(0, 2);
    }
    public void DinoRoar()
    {
        audiosource.PlayOneShot(dinoRoar);
    }

    public void ShipWhoosh() 
    {
        audiosource.PlayOneShot(shipWhoosh[randomIndex]);
    }
}
