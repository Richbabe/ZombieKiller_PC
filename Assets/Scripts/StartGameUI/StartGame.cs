using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    public GameObject BackGroundMusic;
    private AudioClip bgm;

    public void StartGameClick()
    {
        Debug.Log("startGame");
        SceneManager.LoadScene("Scene1");//进入游戏
    }

    public void QuitGameClick()
    {
        Debug.Log("closeGame");
        Application.Quit();//退出游戏
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
