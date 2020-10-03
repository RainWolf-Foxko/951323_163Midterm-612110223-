using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WinStage2 : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip Scored;
    [SerializeField] Stage2Script _stage2S;
    // Start is called before the first frame update
    void Update()
    {
        if(GameInstance.Instance.SFXEnabled == false)
        {
            audioSource.enabled = !audioSource.enabled;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
         audioSource = GetComponent<AudioSource>();
            audioSource.clip = Scored;
            audioSource.Play();
            GameInstance.Instance.score = (int)_stage2S.waitTime * 1000;
            GameInstance.Instance.NumOfWin++;
            SceneManager.LoadScene("MainMenu");
    }
}
