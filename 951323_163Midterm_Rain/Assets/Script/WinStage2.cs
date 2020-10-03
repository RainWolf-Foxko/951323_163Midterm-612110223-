using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WinStage2 : MonoBehaviour
{
    [SerializeField] Stage2Script _stage2S;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameInstance.Instance.score = (int)_stage2S.waitTime * 1000;
            GameInstance.Instance.NumOfWin++;
            SceneManager.LoadScene("MainMenu");
    }
}
