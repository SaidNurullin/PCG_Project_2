using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonsDecorator : MonoBehaviour
{

    [SerializeField] private GameObject[] centerObjects;
    [SerializeField] private GameObject[] wallObjects;
    [SerializeField] private GameObject chest;

    public void PlaceDecorations(int[,] neighborsMap, int[,] dijkstraMap, GameObject[,] tiles, int width, int height, float prob, int minDist)
    {
        for(int i = 0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                if (Random.value < prob)
                {
                    if (neighborsMap[i, j] == 12)
                    {
                        int rand_idx = Random.Range(0, centerObjects.Length);

                        GameObject obj = Instantiate(centerObjects[rand_idx], tiles[i, j].transform);
                        obj.transform.localEulerAngles = new(0, Random.Range(0, 360), 0);
                    }
                    else if (neighborsMap[i, j] == 8)
                    {
                        float chest_prob =Mathf.Min( Mathf.Sqrt((dijkstraMap[i, j] - minDist) / minDist), 0.8f);

                        if(Random.value < chest_prob)
                        {
                            Instantiate(chest, tiles[i, j].transform);
                        }
                        else
                        {
                            int rand_idx = Random.Range(0, wallObjects.Length);

                            Instantiate(wallObjects[rand_idx], tiles[i, j].transform);
                        }
                    }
                }
            }
        }
    }
}
