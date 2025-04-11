using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;

    void Update()
    {
        healthSlider.maxValue = player.max_hp;
        healthSlider.value = player.hp;

        coinsCounterText.text = player.coin.ToString();
    }
}
