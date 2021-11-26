using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUtility : MonoBehaviour
{
    private static SceneUtility instance;
    public static SceneUtility Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
       if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadDinoScene()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void LoadSpaceScene()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void LoadSceneByIndex(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }
}
