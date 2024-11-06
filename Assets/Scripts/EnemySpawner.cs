using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;

public class EnemySpawner : MonoBehaviour
{

    public void SpawnEnemies(int[,] map, int width, int height, int tileSize, GameObject enemy, float prob, GameObject target, NavMeshSurface surface)
    {
        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                if(map[i,j] == 12)
                {
                    if (Random.value < prob)
                    {
                        GameObject _enemy = Instantiate(enemy, new(i * tileSize, 0, j * tileSize), transform.rotation, null);
                        _enemy.GetComponent<Enemy>().SetTarget(target.transform);
                    }
                }
            }
        }

        surface.enabled = false;
        surface.enabled = true;
    }
}
