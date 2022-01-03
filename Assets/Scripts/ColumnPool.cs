using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

    public int columnPoolSize = 5;

    private GameObject[] columns;
    public GameObject columnPrefab;
    private Vector2 objectPoolPosition = new Vector2(-14,0);

    private float timeScenesLastSpawned;
    private float spawnRate = 4f;

    // y maxima 1.4 y -2.9, x 10
    public float columnMin = -2.9f;
    public float columnMax = 1.4f;
    private float spawnXPosition = 10f;

    private int currentColumn;

	// Use this for initialization
	void Start () {
        columns = new GameObject[columnPoolSize];
        for(int i = 0; i < columnPoolSize; i++) {
            columns[i] = Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
        timeScenesLastSpawned += Time.deltaTime;
        if(!GameController.instance.gameOver && timeScenesLastSpawned >= spawnRate) {
            timeScenesLastSpawned = 0;
            float spawnYPosition = Random.Range(columnMin, columnMax);
            //posiciono columna
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            //paso a siguiente columna
            currentColumn++;
            //para no sobre pasar array de columnas
            if(currentColumn >= columnPoolSize) {
                currentColumn = 0;
            }
        }

	}
}
