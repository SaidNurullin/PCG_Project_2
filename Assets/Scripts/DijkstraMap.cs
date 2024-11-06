using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DijkstraMap : MonoBehaviour
{
    // 2D boolean array representing the map (true = walkable, false = obstacle)
    public bool[,] mapGrid;

    // Sentinel value for unreachable cells
    private const int UNREACHABLE = -1;

    // Function to generate the Dijkstra map from the bool array
    public int[,] GenerateDijkstraMap()
    {
        // Get the dimensions of the map
        int width = mapGrid.GetLength(0);
        int height = mapGrid.GetLength(1);

        // Initialize Dijkstra map with sentinel values
        int[,] dijkstraMap = new int[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                dijkstraMap[x, y] = UNREACHABLE;
            }
        }

        // Find the center of the map as the starting point
        int startX = width / 2;
        int startY = height / 2;
        for (int x = startX - 1; x < startX + 2; x++)
        {
            for (int y = startY - 1; y < startY + 2; y++)
            {
                if (mapGrid[x, y]) 
                {
                    startX = x;
                    startY = y;
                    break;
                }
            }
        }

        // Set the starting point to 0 (distance from itself)
        dijkstraMap[startX, startY] = 0;

        // Queue to process cells in order of distance
        Queue<Vector2Int> queue = new Queue<Vector2Int>();
        queue.Enqueue(new Vector2Int(startX, startY));

        // Iterate until the queue is empty
        while (queue.Count > 0)
        {
            // Dequeue the current cell
            Vector2Int currentCell = queue.Dequeue();
            int currentDistance = dijkstraMap[currentCell.x, currentCell.y];

            // Check adjacent cells
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    // Ignore the current cell itself
                    if (dx == 0 && dy == 0)
                    {
                        continue;
                    }

                    // Check if the adjacent cell is within bounds
                    int x = currentCell.x + dx;
                    int y = currentCell.y + dy;
                    if (x >= 0 && x < width && y >= 0 && y < height)
                    {
                        // Check if the cell is walkable (true in the bool array) and unreachable
                        if (mapGrid[x, y] && dijkstraMap[x, y] == UNREACHABLE)
                        {
                            // Set the distance of the adjacent cell
                            dijkstraMap[x, y] = currentDistance + 1;
                            // Enqueue the adjacent cell to be processed
                            queue.Enqueue(new Vector2Int(x, y));
                        }
                    }
                }
            }
        }

        // Return the Dijkstra map
        return dijkstraMap;
    }
}

