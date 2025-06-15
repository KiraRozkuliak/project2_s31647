using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;

    [HideInInspector]
    public Transform parentAfterDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;

        // Запам'ятовуємо, де був предмет
        parentAfterDrag = transform.parent;

        // Переміщаємо предмет на верхній рівень, щоб він не обрізався UI
        transform.SetParent(transform.root);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.raycastTarget = true;

        // Повертаємо предмет назад у слот (або змінений слот)
        transform.SetParent(parentAfterDrag);
    }
}