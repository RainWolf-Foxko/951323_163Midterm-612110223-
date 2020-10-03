using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stage2Script : MonoBehaviour
{
    [SerializeField] Text _scoretext;
    [SerializeField] Text _NumOfWin;
    [SerializeField] Text _NumOfLose;
    [SerializeField] Button _BackBtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _scoretext.text = "Score : " + GameInstance.Instance.score.ToString();
        _NumOfWin.text = "Number Of Win : " + GameInstance.Instance.NumOfWin.ToString();
        _NumOfLose.text = "Number Of Lose : " + GameInstance.Instance.NumOfLose.ToString();
    }
    public void BackClick(Button button){
        SceneManager.LoadScene("StageSelect");
    }
}
