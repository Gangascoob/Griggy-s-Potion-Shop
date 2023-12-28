using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tooltip : MonoBehaviour
{
    public string message;

    /*
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        TooltipController._instance.SetAndShowTooltip(message);
        Debug.Log("pointer enter");
    }



    public void OnPointerExit(PointerEventData pointerEventData)
    {
        TooltipController._instance.HideTooltip();
    }
    */


    public void Enter()
    {
        TooltipController._instance.SetAndShowTooltip(message);
        Debug.Log("pointer enter");
    }

    public void Exit()
    {
        TooltipController._instance.HideTooltip();
    }

}
