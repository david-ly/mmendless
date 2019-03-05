using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour {

    public GameObject platform;
    float endStart;
    float endY;
    public Transform player;
    public LayerMask whatIsGround;
    public GameObject enemy;

    private void Start()
    {
        Generate(player.position.x, player.position.y - 1, player.rotation, 3);
        Generate(endStart + Random.Range(1, 4), endY + Random.Range(-2, 2), player.rotation);
        Generate(endStart + Random.Range(1, 4), endY + Random.Range(-2, 2), player.rotation);
        Generate(endStart + Random.Range(1, 4), endY + Random.Range(-2, 2), player.rotation);
        Generate(endStart + Random.Range(1, 4), endY + Random.Range(-2, 2), player.rotation);
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool platAhead = Physics2D.OverlapPoint(new Vector2(collision.transform.position.x + 1, collision.transform.position.y), whatIsGround);
        if (!platAhead)
        {
            Generate(endStart + Random.Range(1, 4), endY + Random.Range(-2, 2), collision.transform.rotation);
        }
        Destroy(collision.gameObject);
    }

    void Generate(float x, float y, Quaternion rotation, int min = 2)
    {
        int numPlatforms = Random.Range(min, 6);
        int enemyLoc = Random.Range(0, numPlatforms - 1);
        for (int i = 0; i < numPlatforms; i++)
        {
            Instantiate(platform, new Vector2(x, y), rotation);
            x++;
            if (i == enemyLoc)
            {
                Instantiate(enemy, new Vector2(x, y + 1), rotation);
            }
        }
        endStart = x;
        endY = y;
    }
}
