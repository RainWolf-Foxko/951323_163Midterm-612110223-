using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditScript : MonoBehaviour
{
    [SerializeField] Button _BackBtn;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void BackClick(Button button){
        SceneManager.LoadScene("MainMenu");
    }
}
