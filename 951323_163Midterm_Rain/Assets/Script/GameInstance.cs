using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstance : MonoBehaviour
{
    static public GameInstance Instance
    {
        get
        {
            if (_singletonInstance == null)
            {
                _singletonInstance = GameObject.FindObjectOfType<GameInstance>();
                GameObject container = new GameObject("GameInstance");
                _singletonInstance = container.AddComponent<GameInstance>();
            }
            return _singletonInstance;
        }
    }
    static protected GameInstance _singletonInstance = null;
    //private string name;
    private int score{get;set;}
    private int NumOfLose{get;set;}
    private int NumOfWin{get;set;}
    public bool IsOptionMenuActive{get;set;}
    public bool _isMusicEnabled{get;set;}
    public bool SFXEnabled{get;set;}

    void Awake()
    {
        if (_singletonInstance == null)
        {
            _singletonInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (this != _singletonInstance)
            {
                Destroy(this.gameObject);
            }
        }
    }
}