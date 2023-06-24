using UnityEngine;
using UnityEngine.UIElements;

public class TerrainGenerator : MonoBehaviour
{
    [SerializeField] private GameObject corridorPrefab;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float corridorHeight;

    private float spawnY = 5f;
    private float spawnX;

    private void Start()
    {
        spawnX = playerTransform.position.x;

        for (int i = 0; i < 2; i++)
        {
            GameObject corridorSection = Instantiate(corridorPrefab, transform);
            corridorSection.transform.position = new Vector3(spawnX, spawnY, 0f);

            spawnY -= corridorHeight;
        }
    }

    private void Update()
    {
        if (playerTransform.position.y < spawnY + corridorHeight + 2f)
        {
            SpawnCorridorSection();
        }
    }

    private void SpawnCorridorSection()
    {

        GameObject corridorSection = Instantiate(corridorPrefab, transform);
        corridorSection.transform.position = new Vector3(spawnX, spawnY, 0f);

        spawnY -= corridorHeight;
    }
}