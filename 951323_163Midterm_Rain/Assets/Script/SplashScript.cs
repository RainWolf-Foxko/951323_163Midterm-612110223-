using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour
{
    private float waitTime;
    public float startWaitTime = 10;

    [SerializeField] Text _timer;
    [SerializeField] Text _scoretext;
    [SerializeField] Text _NumOfWin;
    [SerializeField] Text _NumOfLose;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        _timer.text = "Timer : " + waitTime.ToString();
        _scoretext.text = "Score : " + GameInstance.Instance.score.ToString();
        _NumOfWin.text = "Number Of Win : " + GameInstance.Instance.NumOfWin.ToString();
        _NumOfLose.text = "Number Of Lose : " + GameInstance.Instance.NumOfLose.ToString();

        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("MainMenu");
        }

        if(waitTime <= 0){
            SceneManager.LoadScene("MainMenu");
        }
        else waitTime -= Time.deltaTime;
    }
}
