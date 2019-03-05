using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour {

    public GameObject platform;

	// Use this for initialization
	void Start () {
        Generate(transform.position.x, transform.position.y + Random.Range(-3, 3), transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Generate(float x, float y, Quaternion rotation, int min = 2)
    {
        int numPlatforms = Random.Range(min, 6);
        for (int i = 0; i < numPlatforms; i++)
        {
            Instantiate(platform, new Vector2(x, y), rotation);
            x++;
        }
        GameObject end = new GameObject("Test");
        end.tag = "EndPlatform";
        end.transform.position = new Vector2(x, y);
        end.AddComponent<BoxCollider2D>();
        end.AddComponent<End>();
    }
}
