using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePlacer : MonoBehaviour
{
    [SerializeField] private GameObject tile_4_6;
    [SerializeField] private GameObject tile_5;
    [SerializeField] private GameObject tile_8_9;
    [SerializeField] private GameObject tile_10;
    [SerializeField] private GameObject tile_12;

    public GameObject[,] PlaceTiles(int[,] neighboursMap, int width, int height, int tileSize)
    {

        GameObject[,] tiles = new GameObject[width, height];

        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                int angle;
                List<int> neighbors = new();

                if (i - 1 < 0) neighbors.Add(0);
                else neighbors.Add(neighboursMap[i - 1, j]);

                if (j - 1 < 0) neighbors.Add(0);
                else neighbors.Add(neighboursMap[i, j - 1]);

                if (i + 1 >= width) neighbors.Add(0);
                else neighbors.Add(neighboursMap[i + 1, j]);

                if (j + 1 >= height) neighbors.Add(0);
                else neighbors.Add(neighboursMap[i, j + 1]);

                GameObject tile = null;

                if (neighboursMap[i,j] == 4 || neighboursMap[i,j] == 6)
                {

                    if (neighbors[0] == 0 && neighbors[2] == 0) angle = 90;
                    else angle = 0;

                    tile = Instantiate(tile_4_6, new(i * tileSize, 0, j * tileSize), transform.rotation);
                    tile.transform.eulerAngles = new(0, angle, 0);


                }
                else if(neighboursMap[i, j] == 5)
                {
                    if (neighbors[0] == 0 && neighbors[1] == 0) angle = 270;
                    else if (neighbors[1] == 0 && neighbors[2] == 0) angle = 180;
                    else if (neighbors[2] == 0 && neighbors[3] == 0) angle = 90;
                    else angle = 0;

                    tile = Instantiate(tile_5, new(i * tileSize, 0, j * tileSize), transform.rotation);

                    tile.transform.eulerAngles = new(0, angle, 0);
                }
                else if (neighboursMap[i, j] == 8 || neighboursMap[i, j] == 9)
                {
                    if (neighbors[0] == 0) angle = 270;
                    else if (neighbors[1] == 0) angle = 180;
                    else if (neighbors[2] == 0) angle = 90;
                    else angle = 0;

                    tile = Instantiate(tile_8_9, new(i * tileSize, 0, j * tileSize), transform.rotation);

                    tile.transform.eulerAngles = new(0, angle, 0);
                }
                else if (neighboursMap[i, j] == 10)
                {
                    if (neighbors[0] == 6) angle = 270;
                    else if (neighbors[1] == 6) angle = 180;
                    else if (neighbors[2] == 6) angle = 90;
                    else angle = 0;

                    tile = Instantiate(tile_10, new(i * tileSize, 0, j * tileSize), transform.rotation);

                    tile.transform.eulerAngles = new(0, angle, 0);
                }
                else if (neighboursMap[i, j] == 12)
                {
                    tile = Instantiate(tile_12, new(i * tileSize, 0, j * tileSize), transform.rotation);
                }

                tiles[i, j] = tile;
            }
        }

        return tiles;
    }
}
