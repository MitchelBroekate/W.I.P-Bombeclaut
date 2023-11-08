using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BaseScript : MonoBehaviour
{
    public int health = 1500;

    public int moneyAmount = 250;

    [SerializeField]
    private TextMeshProUGUI textMoney;

    private void Update()
    {
        textMoney.text = moneyAmount.ToString();
    }

}
