using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platform;

	// Use this for initialization
	void Start () {
        regenerate();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void regenerate()
    {
        Instantiate(platform, new Vector2(-9.133f, -3.067f), gameObject.transform.rotation);
    }
}
