
using System.Collections.Generic;
using UnityEngine;

public class SpawningBoxes : MonoBehaviour
{
    public Transform[] spawnPositions;

    private float t;

    public GameObject boxPrefab;
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 4)
        {
            t = 0;
            int randomNumber = Random.Range(0, spawnPositions.Length);

            Instantiate(boxPrefab, spawnPositions[randomNumber]);

        }
    }
}
