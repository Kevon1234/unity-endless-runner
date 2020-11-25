using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector2 boardBorders;
    [SerializeField] private float generationoffset = 10f;
    [SerializeField] private float generationdistance = 100f;
    [SerializeField] private float destructionDistance = 20f;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private Transform obstaclesParent;
    private float lastZOffset;

    private void Start()
    {
        GenerateObstacles()

    }

    private void GenerateObstacles()
    {
        while(lastZOffset < target.position.z + generationdistance)
        {
            Instantiate(obstaclePrefab, Vector3.zero, Quaternion.identity, obstaclesParent);
            lastZOffset += generationoffset;
        }
    }

    private void GenerateObstacle()
    {

    }
}
