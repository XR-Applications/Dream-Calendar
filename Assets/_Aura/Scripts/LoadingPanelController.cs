using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingPanelController : MonoBehaviour
{

    public void LoadSceneByIndex(int index)
    {
           AmbientMusicManager.Instance.PlayButtonPressFX();
           SceneManager.LoadSceneAsync(index);
    }
}
