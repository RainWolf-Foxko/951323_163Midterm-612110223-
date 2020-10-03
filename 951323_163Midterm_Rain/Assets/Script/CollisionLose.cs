using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionLose : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip Scored;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameInstance.Instance.SFXEnabled == false)
        {
            audioSource.enabled = !audioSource.enabled;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = Scored;
            audioSource.Play();
            GameInstance.Instance.NumOfLose++;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
