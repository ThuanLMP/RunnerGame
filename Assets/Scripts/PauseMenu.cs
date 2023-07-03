using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PausePanel;


    // Update is called once per frame
    void Update()
    {

    }
    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Cotinute()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
}
