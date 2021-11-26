using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaptorFxControl : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip raptorRoar;
   public void RaptorRoar()
    {
        audioSource.PlayOneShot(raptorRoar);
    }
}
