using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARUtilityManager : MonoBehaviour
{
    public void LoadSceneByIndex(int sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
