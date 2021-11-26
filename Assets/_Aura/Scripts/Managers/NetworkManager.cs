using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkManager : MonoBehaviour
{
    public GameObject internetIndicator;
    private void Start()
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            Debug.Log("Network is reachable.");
            internetIndicator.SetActive(false);
        }
        if(Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.Log("Network is not reachable.");
            internetIndicator.SetActive(true);
        }
    }

    public void DismissInternetIndicator() 
    {
        if (Application.internetReachability != NetworkReachability.NotReachable)
        {
            Debug.Log("Network is reachable.");
            internetIndicator.SetActive(false);
        }
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            Debug.Log("Network is not reachable.");
            internetIndicator.SetActive(true);
        }
    }
}
