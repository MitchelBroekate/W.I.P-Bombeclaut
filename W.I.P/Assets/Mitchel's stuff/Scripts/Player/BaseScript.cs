using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaseScript : MonoBehaviour
{
    public int health = 1500;

    public int moneyAmount = 250;

    public Slider healthSlider;

    [SerializeField]
    private TextMeshProUGUI textMoney;

    private void Update()
    {
        textMoney.text = moneyAmount.ToString();

        healthSlider.value = health;
    }

}
