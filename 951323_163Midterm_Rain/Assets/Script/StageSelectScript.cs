using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectScript : MonoBehaviour
{
    [SerializeField] Button _Stage1Btn;
    [SerializeField] Button _Stage2Btn;
    [SerializeField] Button _BackBtn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
