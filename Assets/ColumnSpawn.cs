using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawn : MonoBehaviour
{
    public float spawnRate = 4f;
    public int columnSpawnSize = 5;
    public float columnXMin = -2f;
    public float columnXMax = 2f;

    private float timeSinceLastSpawn;
    private float spawnYPos = -20f;
    private int currentColumn = 0;

    public GameObject columnsPrefab;

    private GameObject[] columns;
    private Vector2 objectSpawnPosition = new Vector2(-1500f,-2500f);


    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnSpawnSize];
        for (int i = 0; i < columnSpawnSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnsPrefab, objectSpawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if(!GameControl.instance.gameOver && timeSinceLastSpawn >= spawnRate)
        {
            timeSinceLastSpawn = 0;
            float spawnXPos = Random.Range(columnXMin, columnXMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPos, spawnYPos);

            currentColumn++;

            if(currentColumn >= columnSpawnSize) { currentColumn = 0; }
        }
    }
}
