using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene("Start");
        }   
    }
    // Update is called once per frame
    void Update () {
		
	}
}
