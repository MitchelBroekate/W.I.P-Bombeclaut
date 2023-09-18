using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOpen : MonoBehaviour
{
    public GameObject shop;
    public bool shopIsOpen = false;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if(shopIsOpen == false)
            {
                shop.SetActive(true);
                shopIsOpen = true;
            }
            else
            {
                shop.SetActive(false);
                shopIsOpen = false;
            }
        }
    }
}
