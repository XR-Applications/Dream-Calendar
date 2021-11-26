using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class ARWorldControl : MonoBehaviour
{
    [SerializeField] GameObject world;
    [SerializeField] GameObject seeker;


    private void Start()
    {
        seeker.SetActive(true);
        DeactivateWorld();
    }


    public void TargetFound()
    {
        seeker.SetActive(false);
        ActivateWorld();

    }
    public void TargetLost()
    {
        seeker.SetActive(true);
        DeactivateWorld();

    }
    public void DeactivateWorld()
    {
        world.SetActive(false);
    }

    public void ActivateWorld()
    {
        world.SetActive(true);

    }
}
