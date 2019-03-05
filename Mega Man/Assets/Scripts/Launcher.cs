using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour {

    public GameObject projectile;
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                Instantiate(projectile, transform.position, transform.rotation);
            }
        } else
        {
            if (player.transform.position.x >= transform.position.x - 6) {
                Instantiate(projectile, transform);
            }
        }
	}
}
