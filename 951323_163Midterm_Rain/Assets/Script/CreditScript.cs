using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditScript : MonoBehaviour
{
    private AudioSource sound;
    [SerializeField] Text _scoretext;
    [SerializeField] Text _NumOfWin;
    [SerializeField] Text _NumOfLose;
    [SerializeField] Button _BackBtn;
    void Start()
    {
         sound  = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(GameInstance.Instance._isMusicEnabled == false)
        {
            sound.enabled = !sound.enabled;
        }
        _scoretext.text = "Score : " + GameInstance.Instance.score.ToString();
        _NumOfWin.text = "Number Of Win : " + GameInstance.Instance.NumOfWin.ToString();
        _NumOfLose.text = "Number Of Lose : " + GameInstance.Instance.NumOfLose.ToString();
    }
    public void BackClick(Button button){
        SceneManager.LoadScene("MainMenu");
    }
}
