using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.InputSystem;
public class DragAndDrop : MonoBehaviour, IDragHandler, IBeginDragHandler,  IEndDragHandler
{

    public Vector3 mousePosition;
    public bool moving = false; 



    public void OnBeginDrag(PointerEventData eventData)
    {
        moving = true;
        mousePosition = GameManager.Instance.ScreenPos + Camera.main.WorldToScreenPoint(transform.position);
        Debug.Log("Dragging: " + gameObject.name);
    }


    public void OnDrag(PointerEventData eventData)
    {
        if (moving)
        {
            transform.position = Camera.main.ScreenToWorldPoint(GameManager.Instance.ScreenPos) + new Vector3(0, 0, 7);
        } 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        moving = false; 
    }





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
