using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class WorldControl : MonoBehaviour
{
    [SerializeField] List<GameObject> worlds;
    [SerializeField] GameObject seeker;
    private bool _canActivateWorlds = false;

    [SerializeField] Text infoText;
    private void OnEnable()
    {
        VuforiaApplication.Instance.OnVuforiaStarted += OnVuforiaStarted;
    }
    private void Start()
    {
        seeker.SetActive(true);
        DeactivateWorlds();    
    }

    private void OnVuforiaStarted()
    {
        infoText.text = "Vuforia Initialized!";
        VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(FocusMode.FOCUS_MODE_MACRO);
    }

    public void TargetFound()
    {
        seeker.SetActive(false);
        _canActivateWorlds = true;
    }
    public void TargetLost()
    {
        seeker.SetActive(true);
        _canActivateWorlds = false;
    }
    public void DeactivateWorlds()
    {
        foreach(var w in worlds)
        {
            w.SetActive(false);
        }
    }

    public void ActivateWorldByIndex(int indexOfWorld)
    {
        foreach (var w in worlds)
        {
            w.SetActive(false);
        }
        Debug.Log("Activating world: " + indexOfWorld);
        worlds[indexOfWorld].SetActive(true);
       
    }
}
