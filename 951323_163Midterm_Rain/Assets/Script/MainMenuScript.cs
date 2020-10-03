using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private float waitTime;
    public float startWaitTime = 5;
    private Vector3 prevMousePosition = Vector3.zero;

    [SerializeField] Text _timer;
    [SerializeField] Button _StageBtn;
    [SerializeField] Button _OptionBtn;
    [SerializeField] Button _CreditBtn;
    [SerializeField] Button _ExitBtn;
    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
    }
    // Update is called once per frame
    void Update()
    {
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
