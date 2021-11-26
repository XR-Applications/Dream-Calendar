using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UtilityController : MonoBehaviour
{
    public GameObject homeBtn;
    private void Awake()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            homeBtn.SetActive(false);
        }
        else
        {
            homeBtn.SetActive(true);
        }
    }
    public void ExitApplication()
    {
        Application.Quit();
    }

    public void GoToHome()
    {
        AmbientMusicManager.Instance.PlayButtonPressFX();
        SceneManager.LoadSceneAsync(0);
    }
}
