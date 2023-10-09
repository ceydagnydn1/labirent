using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_kod : MonoBehaviour
{
    private GameObject MainMenu;
    private Button PlayButton;
    private Button SettingButton;
    private Button QuitButton;

    private void Awake()
    {
        MainMenu = GameObject.Find("MainMenu");
        PlayButton = GameObject.Find("Playbutton").GetComponent<Button>();
        QuitButton = GameObject.Find("Quitbutton").GetComponent<Button>();
    
    }
    private void Start()
    {
        MainMenu.SetActive(true);
        
        QuitButton.onClick.AddListener(QuitGame);
        PlayButton.onClick.AddListener(OpenPlayMenu);
    }
    #region Ana Menü
    private void OpenPlayMenu()
    {
        SceneManager.LoadScene(1);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    #endregion
}
