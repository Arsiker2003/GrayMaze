using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGameClick()
    {
        SceneManager.LoadScene("Level1");
    }
    public void ToMainMenuClick()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGameClick()
    {
        Application.Quit();
    }
}
