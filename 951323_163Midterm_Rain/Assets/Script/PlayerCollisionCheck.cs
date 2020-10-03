using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollisionCheck : MonoBehaviour
{
     [SerializeField] Stage2Script _stage2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision){

        if (collision.gameObject.tag == "Item1"){
            _stage2.waitTime +=3;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Item2"){
            _stage2.waitTime -=5;
            Destroy(collision.gameObject);
            }
        else if (collision.gameObject.tag == "Item3"){
            GameInstance.Instance.score += 500;
            Destroy(collision.gameObject);
            }
        }
    }
