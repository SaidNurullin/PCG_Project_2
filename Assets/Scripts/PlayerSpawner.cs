using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{

    public void SpawnPlayer(int[,] map, int width, int height, GameObject player, int tileSize)
    {
        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                if(map[i, j] == 0)
                {
                    Instantiate(player, new(i * tileSize, 0, j * tileSize), transform.rotation, null);
                }
            }
        }
    }
}
