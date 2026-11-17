using UnityEngine;

public class MovingSpawnBoxesUp : MonoBehaviour
{
    public GameObject boxSpawnLocation;
    public Transform playerPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(playerPos.position, boxSpawnLocation.transform.position);
        if (distance < 6)
        {
            boxSpawnLocation.transform.position += new Vector3(0, 1, 0);
        }
    }
}
