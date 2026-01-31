using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("References")]
    public GameObject enemyPrefab;
    public Transform player;

    [Header("Spawn Area (Rectangle Edges)")]
    public float minX = -7f;
    public float maxX = 15f;
    public float minZ = -7;
    public float maxZ = 15f;
    public float ySpawn = 0.5f;

    [Header("Timing")]
    public float spawnInterval = 0.7f;

    private float timer;

    void Update()
    {
        if (enemyPrefab == null || player == null) return;

        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            SpawnOnEdge();
        }
    }

    void SpawnOnEdge()
    {
        Vector3 pos = GetRandomEdgePosition();
        GameObject e = Instantiate(enemyPrefab, pos, Quaternion.identity);

        // Spawn edilen enemy'ye player hedefini ver
        EnemyMove move = e.GetComponent<EnemyMove>();
        if (move != null)
            move.target = player;
    }

    Vector3 GetRandomEdgePosition()
    {
        int edge = Random.Range(0, 4);
        float x, z;

        switch (edge)
        {
            case 0: // üst (maxZ)
                x = Random.Range(minX, maxX);
                z = maxZ;
                break;

            case 1: // alt (minZ)
                x = Random.Range(minX, maxX);
                z = minZ;
                break;

            case 2: // sað (maxX)
                x = maxX;
                z = Random.Range(minZ, maxZ);
                break;

            default: // sol (minX)
                x = minX;
                z = Random.Range(minZ, maxZ);
                break;
        }
        return new Vector3(x, ySpawn, z);
    }
}
