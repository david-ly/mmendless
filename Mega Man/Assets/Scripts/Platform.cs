using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    public GameObject platform;
    public LayerMask whatIsGround;

    void Generate(float x, float y, Quaternion rotation, int min = 2)
    {
        int numPlatforms = Random.Range(min, 6);
        for (int i = 0; i < numPlatforms; i++)
        {
            Instantiate(platform, new Vector2(x, y), rotation);
            x++;
        }
    }
}
