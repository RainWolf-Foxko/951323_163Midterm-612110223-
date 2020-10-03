using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private AudioSource sound;
    private float waitTime;
    public float startWaitTime = 5;
    private Vector3 prevMousePosition = Vector3.zero;

    [SerializeField] Text _timer;
    [SerializeField] Text _scoretext;
    [SerializeField] Text _NumOfWin;
    [SerializeField] Text _NumOfLose;

    [SerializeField] Button _StageBtn;
    [SerializeField] Button _OptionBtn;
    [SerializeField] Button _CreditBtn;
    [SerializeField] Button _ExitBtn;
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
        _scoretext.text = "Score : " + GameInstance.Instance.score.ToString();
        _NumOfWin.text = "Number Of Win : " + GameInstance.Instance.NumOfWin.ToString();
        _NumOfLose.text = "Number Of Lose : " + GameInstance.Instance.NumOfLose.ToString();
        _timer.text = "Timer : " + waitTime.ToString();

        if(Input.anyKeyDown || Input.mousePosition != prevMousePosition) waitTime = startWaitTime;
        prevMousePosition = Input.mousePosition;

        if (GameInstance.Instance.IsOptionMenuActive == true) waitTime = startWaitTime;
        
        if(waitTime <= 0){
            SceneManager.LoadScene("Splash");
        }
        else waitTime -= Time.deltaTime;
    }

    public void StageClick(Button button){
        SceneManager.LoadScene("StageSelect");
    }
    public void OptionClick(Button button){
        if (GameInstance.Instance.IsOptionMenuActive == false){
            SceneManager.LoadScene("Option", LoadSceneMode.Additive);
            GameInstance.Instance.IsOptionMenuActive = true;
        }
    }
    public void CreditClick(Button button){
        SceneManager.LoadScene("Credit");
    }
    public void ExitClick(Button button){
        SceneManager.LoadScene("Splash");
    }
}
