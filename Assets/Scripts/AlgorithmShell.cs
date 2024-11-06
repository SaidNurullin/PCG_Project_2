using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Unity.AI.Navigation;


public class AlgorithmShell : MonoBehaviour
{
    [SerializeField] private Digger digger;
    [SerializeField] private DijkstraMap dijkstraMap;
    [SerializeField] private NeighborCounter neighborCounter;
    [SerializeField] private DeadEndRemover deadEndRemover;
    [SerializeField] private TilePlacer tilePlacer;
    [SerializeField] private DungeonsDecorator decorator;
    [SerializeField] private PlayerSpawner playerSpawner;
    [SerializeField] private EnemySpawner enemySpawner;
    [SerializeField] private NavMeshSurface surface;

    [SerializeField] private int gridWidth = 20;
    [SerializeField] private int gridHeight = 20;
    [SerializeField] private int numOfRooms = 5;
    [Range(6, 12)] [SerializeField] private int minRoomSize;
    [Range(6, 16)] [SerializeField] private int maxRoomSize;
    [Range(3, 7)] [SerializeField] private int minCorridorSize;
    [Range(3, 10)] [SerializeField] private int maxCorridorSize;
    [SerializeField] private bool randomizeRoomSizes;
    [SerializeField] private bool randomizeCorridorSizes;
    [SerializeField] private int tileSize = 1;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemy;
    [SerializeField] private float enemy_spawn_prob;
    [SerializeField] private float decorations_spawn_prob;
    [SerializeField] private int chest_spawn_min_dist;


    // Start is called before the first frame update
    void Start()
    {
        bool[,] map = digger.GenerateMap(
            gridWidth, gridHeight, numOfRooms,
            minRoomSize, maxRoomSize, minCorridorSize, maxCorridorSize,
            randomizeRoomSizes, randomizeCorridorSizes);

        dijkstraMap.mapGrid = map;
        int[,] d_map = dijkstraMap.GenerateDijkstraMap();
        PrintMap(d_map);

        neighborCounter.mapGrid = map;
        int[,] neighboursMap = neighborCounter.CountNeighbors();

        neighboursMap = deadEndRemover.RemoveDeadEnds(neighboursMap, gridWidth, gridHeight);

        PrintMap(neighboursMap);

        GameObject[,] tiles = tilePlacer.PlaceTiles(neighboursMap, gridWidth, gridHeight, tileSize);

        decorator.PlaceDecorations(neighboursMap, d_map, tiles, gridWidth, gridHeight, decorations_spawn_prob, chest_spawn_min_dist);

        surface.BuildNavMesh();

        playerSpawner.SpawnPlayer(d_map, gridWidth, gridHeight, player, tileSize);

        GameObject target = FindObjectOfType<PlayerMovement>().gameObject;

        enemySpawner.SpawnEnemies(neighboursMap, gridWidth, gridHeight, tileSize, enemy, enemy_spawn_prob, target, surface);
    }

    public void PrintMap(int[,] map)
    {
        // Get the dimensions of the map
        int width = map.GetLength(0);
        int height = map.GetLength(1);

        // Print each row
        for (int y = 0; y < height; y++)
        {
            // Print row number
            Debug.Log(y.ToString().PadLeft(2) + " | " + string.Join(" ", Enumerable.Range(0, width).Select(x => map[x, y].ToString().PadLeft(2))));
        }
    }

}
