using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnHoverFontSize : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public TMP_Text text;

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.fontSize = 100f;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        text.fontSize = 90f;
    }
}
