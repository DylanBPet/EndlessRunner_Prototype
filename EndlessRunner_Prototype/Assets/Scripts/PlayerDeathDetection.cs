using UnityEngine;

public class PlayerDeathDetection : MonoBehaviour
{
    public SpawningBoxes spawnBoxesScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Player has Diead");
        for (int i = spawnBoxesScript.spawnedBoxes.Count -1; i >= 0; i--)
        {
            GameObject objectToRemove = spawnBoxesScript.spawnedBoxes[i];
            Destroy(objectToRemove);
            spawnBoxesScript.spawnedBoxes.Remove(objectToRemove);
        }
    }
}
