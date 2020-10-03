using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage1Script : MonoBehaviour
{
    [SerializeField] Text _timeLeft;
    [SerializeField] Text _scoretext;
    [SerializeField] Text _NumOfWin;
    [SerializeField] Text _NumOfLose;

    public float waitTime;
    public float startWaitTime = 30;
     [SerializeField] Button _BackBtn;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
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
