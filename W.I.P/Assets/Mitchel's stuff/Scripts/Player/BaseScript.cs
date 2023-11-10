using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaseScript : MonoBehaviour
{
    public int health = 1000;

    public int moneyAmount = 250;

    public Slider healthSlider;

    [SerializeField]
    private GameObject deathScreen;

    [SerializeField]
    private TextMeshProUGUI textMoney;

    private void Update()
    {
        textMoney.text = moneyAmount.ToString();

        healthSlider.value = health;

        death();
    }

    void death()
    {
        if(health < 1)
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
    }

}
