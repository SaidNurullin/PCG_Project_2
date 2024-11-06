using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private GameObject[] weapons;
    [SerializeField] private float[] probs;

    private bool isOpened = false;
    public void OpenChest()
    {
        if (isOpened) return;
        float rand = Random.value;

        Debug.Log(rand);

        float prob = 0;

        for(int i = 0; i < probs.Length; i++)
        {
            prob += probs[i];

            if(rand < prob)
            {
                Instantiate(weapons[i], transform.position + Vector3.up, transform.rotation, null);
                break;
            }
        }

        isOpened = true;
    }
}
