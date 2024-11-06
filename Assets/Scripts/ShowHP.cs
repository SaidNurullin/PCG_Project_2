using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHP : MonoBehaviour
{
    [SerializeField] private Text hpText;
    [SerializeField] private Slider hpSlider;

    // Update is called once per frame
    void Update()
    {
        hpText.text = GetComponent<Health>().currentHealth.ToString();
        hpSlider.value = (float)GetComponent<Health>().currentHealth / (float)GetComponent<Health>().maxHealth;
    }
}
