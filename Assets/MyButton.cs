using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MyButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    public Image BackGroundImage;

    private void Start()
    {
        BackGroundImage.color = new Color(0, 0, 0, 0);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        BackGroundImage.color = new Color(0, 0, 0, 0.4f);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        BackGroundImage.color = new Color(0, 0, 0, 0.1f);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        BackGroundImage.color = new Color(0, 0, 0, 0.1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        BackGroundImage.color = new Color(0, 0, 0, 0);
    }
}
