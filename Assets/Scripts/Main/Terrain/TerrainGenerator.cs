using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class TerrainGenerator : MonoBehaviour
{
    [SerializeField] private GameObject corridorPrefab;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float corridorHeight;
    [SerializeField] private GameObject[] Beans;

    private float spawnY = 5f;
    private float spawnX;

    private void Start()
    {
        spawnX = playerTransform.position.x;

        for (int i = 0; i < 5; i++)
        {
            GameObject corridorSection = Instantiate(corridorPrefab, transform);
            corridorSection.transform.position = new Vector3(spawnX, spawnY, 0f);

            spawnY -= corridorHeight;
        }
    }

    private void Update()
    {
        if (playerTransform.position.y < spawnY + corridorHeight + 5f)
        {
            SpawnCorridorSection();
        }
    }

    private void SpawnCorridorSection()
    {
        GameObject corridorSection = Instantiate(corridorPrefab, transform);
        corridorSection.transform.position = new Vector3(spawnX, spawnY, 0f);
        for (int i = 0; i < Random.Range(1, 2); i++)
        {
            SpawnBean();
        }
        spawnY -= corridorHeight;
    }

    private void SpawnBean()
    {
        int randomBean = Random.Range(0,Beans.Length);

        GameObject bean = Instantiate(Beans[randomBean], transform);
        bean.transform.position = new Vector3(Random.Range(spawnX - 3, spawnX + 3), Random.Range(spawnY - 3, spawnY + 3), 0f);
    }
}