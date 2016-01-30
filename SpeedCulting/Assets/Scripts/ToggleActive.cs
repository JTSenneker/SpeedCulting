using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ToggleActive : MonoBehaviour, IPointerClickHandler
{

    GameController controller;

    void Start()
    {
        controller = GameObject.Find("Main Camera").GetComponent<GameController>();
    }

    public void OnPointerClick(PointerEventData data)
    {
        controller.ToggleButtons();
    }
}
