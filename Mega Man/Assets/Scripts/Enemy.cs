using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            SceneManager.LoadScene("Start");
        }
    }

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update () {
		
	}
}
