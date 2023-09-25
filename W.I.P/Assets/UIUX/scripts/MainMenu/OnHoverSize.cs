using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnHoverSize : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource sFX;
    public AudioClip whoosh;
    public Vector3 startFontSize;
    public void Start()
    {
        startFontSize = transform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        sFX.clip = whoosh;
        sFX.Play();
        transform.localScale *= 1.1f;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = startFontSize;
    }
}
