using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinStage1 : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip Scored;
    void Update()
    {
        if(GameInstance.Instance.SFXEnabled == false)
        {
            audioSource.enabled = !audioSource.enabled;
        }
    }
    [SerializeField] Stage1Script _stage1S;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = Scored;
            audioSource.Play();
            GameInstance.Instance.score = (int)_stage1S.waitTime * 1000;
            GameInstance.Instance.NumOfWin++;
            SceneManager.LoadScene("Stage2");
    }
}