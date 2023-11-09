using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnHoverShowTower : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public TMP_Text towerNameShower;
    public TMP_Text towerCostShower;
    public TMP_Text towerDescription;
    public string cost;
    public string towerName;
    public string description;
    public void OnPointerEnter(PointerEventData eventData)
    {
        towerNameShower.text = towerName;
        towerCostShower.text = cost;
        towerDescription.text = description;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        towerNameShower.text = "Choose a tower";
        towerCostShower.text = "0";
        towerDescription.text = "Hover over a tower to get description";
    }
}
