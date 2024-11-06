using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeighborCounter : MonoBehaviour
{

    public bool[,] mapGrid;

    public int[,] CountNeighbors()
    {
        // Get the dimensions of the map
        int width = mapGrid.GetLength(0);
        int height = mapGrid.GetLength(1);

        // Create a new array to store neighbor counts
        int[,] neighborCounts = new int[width, height];

        // Iterate over each cell in the map
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // If the cell is walkable (true)
                if (mapGrid[x, y])
                {
                    // Count neighbors using Moore neighborhood
                    neighborCounts[x, y] = CountVonNeumannNeighbors(x, y, width, height) + CountMooreNeighbors(x, y, width, height);
                }
            }
        }

        // Return the array of neighbor counts
        return neighborCounts;
    }

    // Function to count Moore neighbors for a given cell
    private int CountMooreNeighbors(int x, int y, int width, int height)
    {
        int count = 0;

        // Iterate over the 8 neighbors (Moore neighborhood)
        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                // Ignore the cell itself
                if (dx == 0 && dy == 0)
                {
                    continue;
                }

                // Check if the neighbor is within bounds and walkable
                int nx = x + dx;
                int ny = y + dy;
                if (nx >= 0 && nx < width && ny >= 0 && ny < height && mapGrid[nx, ny])
                {
                    count++;
                }
            }
        }

        // Return the neighbor count
        return count;
    }

    private int CountVonNeumannNeighbors(int x, int y, int width, int height)
    {
        int count = 0;

        // Iterate over the 4 neighbors (von Neumann neighborhood)
        for (int dx = -1; dx <= 1; dx += 2) // Check left and right
        {
            int nx = x + dx;
            if (nx >= 0 && nx < width && mapGrid[nx, y])
            {
                count++;
            }
        }

        for (int dy = -1; dy <= 1; dy += 2) // Check up and down
        {
            int ny = y + dy;
            if (ny >= 0 && ny < height && mapGrid[x, ny])
            {
                count++;
            }
        }

        // Return the neighbor count
        return count;
    }

}
