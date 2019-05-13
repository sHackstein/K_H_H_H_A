using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public int i;

	// Use this for initialization
	void Start () {
       DontDestroyOnLoad(this);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SceneManager.LoadScene("Scene" + i++, LoadSceneMode.Single);
        }
    }
}
