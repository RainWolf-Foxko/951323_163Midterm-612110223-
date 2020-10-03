using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionScript : MonoBehaviour
{
    [SerializeField] Toggle _toggleMusic;
    [SerializeField] Toggle _toggleSFX;
    [SerializeField] Button _backButton;

    void Start()
    {
        _toggleMusic.isOn = GameInstance.Instance._isMusicEnabled;
        _toggleSFX.isOn = GameInstance.Instance.SFXEnabled;
    }

    void Update()
    {
        
    }
    public void BackButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("Option");
        GameInstance.Instance.IsOptionMenuActive = false;
    }
    public void OnToggleMusic(Toggle toggle)
    {
        GameInstance.Instance._isMusicEnabled = _toggleMusic.isOn;
    }
    public void OnToggleSFX(Toggle toggle)
    {
        GameInstance.Instance.SFXEnabled = _toggleSFX.isOn;
    }
}
