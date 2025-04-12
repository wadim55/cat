using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class button : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public static Action click;
    public static Action enterButton;
    public static Action exitButton;

    private void OnEnable()
    {
        //Cat.wanaEat += ChangeColor();
    }

    private void OnDisable()
    {
        //Cat.wanaEat -= ChangeColor();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
    
        enterButton?.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        exitButton?.Invoke();
    }

    void ChangeColor()
    {
        gameObject.GetComponent<Image>().color = Color.red;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        click?.Invoke();
    }
}
