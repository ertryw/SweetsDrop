using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameController game;
    public float spawnTime = 1.0f;
    public GameObject[] items;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    public void SpawnRandomItem()
    {
        GameObject item = items[Random.Range(0, items.Length - 1)];
        Vector3 pos = new Vector3(Random.Range(-5, 5), 0, 0);
        Instantiate(item, pos, Quaternion.identity);

    }

    IEnumerator SpawnRoutine()
    {

        while (game.CanGame)
        {
            //print("spawn");
            SpawnRandomItem();
            yield return new WaitForSeconds(spawnTime);
        }
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
