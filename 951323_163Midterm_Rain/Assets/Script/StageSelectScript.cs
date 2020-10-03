using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectScript : MonoBehaviour
{
    private AudioSource sound;
    [SerializeField] Text _scoretext;
    [SerializeField] Text _NumOfWin;
    [SerializeField] Text _NumOfLose;
    [SerializeField] Button _Stage1Btn;
    [SerializeField] Button _Stage2Btn;
    [SerializeField] Button _BackBtn;

    // Start is called before the first frame update
    void Start()
    {
        sound  = GetComponent<AudioSource>();
    }

    // Update is called once per frame
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
    public void Stage1Click(Button button){
        SceneManager.LoadScene("Stage1");
    }
    public void Stage2Click(Button button){
        SceneManager.LoadScene("Stage2");
    }
    public void BackClick(Button button){
        SceneManager.LoadScene("MainMenu");
    }
}
