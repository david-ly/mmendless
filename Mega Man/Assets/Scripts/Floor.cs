using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Floor : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            print("Player");
            SceneManager.LoadScene("Start");
        }
    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.y);
	}
}
