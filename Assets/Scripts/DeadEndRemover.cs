using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEndRemover : MonoBehaviour
{

    public int[,] RemoveDeadEnds(int[,] map, int width, int height)
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (map[i, j] == 2)
                {
                    map[i, j] = 0;
                    List<int> neighbors = new();

                    if (i - 1 < 0) neighbors.Add(0);
                    else neighbors.Add(map[i - 1, j]);

                    if (j - 1 < 0) neighbors.Add(0);
                    else neighbors.Add(map[i, j - 1]);

                    if (i + 1 >= width) neighbors.Add(0);
                    else neighbors.Add(map[i + 1, j]);

                    if (j + 1 >= height) neighbors.Add(0);
                    else neighbors.Add(map[i, j + 1]);

                    if (neighbors[0] == 4) RemoveDeadEnd(map, Vector2.left, i - 1, j);
                    else if (neighbors[1] == 4) RemoveDeadEnd(map, Vector2.down, i, j - 1);
                    else if (neighbors[2] == 4) RemoveDeadEnd(map, Vector2.right, i + 1, j);
                    else if (neighbors[3] == 4) RemoveDeadEnd(map, Vector2.up, i, j + 1);

                }
            }
        }

        return map;
    }

    private void RemoveDeadEnd(int[,] map, Vector2 direction, int x, int y)
    {
        while (true)
        {
            if (map[x, y] != 4 && map[x, y] != 6)
            {
                if (map[x, y] == 10) map[x, y] = 8;
                return;
            }
            map[x, y] = 0;

            x += (int)direction[0];
            y += (int)direction[1];
        }
    }

}
