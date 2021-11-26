using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

public class SceneLoadingManager : MonoBehaviour
{
    public Image loadingBar;
    public GameObject loadingText;
    private float progress;
    private void Start()
    {
        loadingBar.enabled = false;
        loadingText.SetActive(false);
    }
    public void LoadSceneByLabel(string label)
    {
        AmbientMusicManager.Instance.PlayButtonPressFX();
        loadingText.SetActive(true);
        loadingBar.enabled = true;
        //Addressables.LoadSceneAsync(label, LoadSceneMode.Single, true).Completed += SceneLoadingManager_Completed;
        StartCoroutine(StartSceneLoad(label));
    }

    IEnumerator StartSceneLoad(string label)
    {
   
        var handle = Addressables.LoadSceneAsync(label, LoadSceneMode.Single, true);
          
        while (handle.GetDownloadStatus().Percent < 1f)
        {
            yield return new WaitForSeconds(2f);
            loadingBar.fillAmount = handle.GetDownloadStatus().Percent;
            if(handle.GetDownloadStatus().Percent < 0.000001f)
            {
                loadingText.GetComponent<Text>().text = "Please turn on Wifi/data and try again";
            }
            else
            {
                loadingText.GetComponent<Text>().text = "loading Scene...";
            }
        }
        
        handle.Result.ActivateAsync();
       
    }
    
   
}
