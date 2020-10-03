using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage2Script : MonoBehaviour
{
    private AudioSource sound;
    [SerializeField] Text _timeLeft;
    [SerializeField] Text _scoretext;
    [SerializeField] Text _NumOfWin;
    [SerializeField] Text _NumOfLose;
    [SerializeField] Button _BackBtn;
    public float waitTime;
    public float startWaitTime = 20;
    // Start is called before the first frame update
    void Start()
    {
        
         sound  = GetComponent<AudioSource>();
         waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameInstance.Instance._isMusicEnabled == false)
        {
            sound.enabled = !sound.enabled;
        }
        _timeLeft.text = "TimeLeft : " + waitTime.ToString();
        _scoretext.text = "Score : " + GameInstance.Instance.score.ToString();
        _NumOfWin.text = "Number Of Win : " + GameInstance.Instance.NumOfWin.ToString();
        _NumOfLose.text = "Number Of Lose : " + GameInstance.Instance.NumOfLose.ToString();

        if(waitTime <= 0){
            GameInstance.Instance.NumOfLose++;
            SceneManager.LoadScene("MainMenu");
        }
        else waitTime -= Time.deltaTime;
    }
    public void BackClick(Button button){
        SceneManager.LoadScene("StageSelect");
    }
}
