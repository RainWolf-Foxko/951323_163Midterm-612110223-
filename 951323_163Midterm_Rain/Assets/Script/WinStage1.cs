using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinStage1 : MonoBehaviour
{
    [SerializeField] Stage1Script _stage1S;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
            GameInstance.Instance.score = (int)_stage1S.waitTime * 1000;
            GameInstance.Instance.NumOfWin++;
            SceneManager.LoadScene("Stage2");
    }
}
