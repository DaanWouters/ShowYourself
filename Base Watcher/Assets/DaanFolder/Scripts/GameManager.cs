using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Vector3 ScreenPos;
    public GameObject selectObject;
    private Camera Cam;



    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            Debug.Log("Destroy");
        }
        else
        {
            Instance = this;
        }
        Cam = Camera.main;
    }



    public void ScreenPosition(InputAction.CallbackContext ctx)
    {
        ScreenPos = ctx.ReadValue<Vector2>();
    }

    public void ButtonPress(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            Ray ray = Cam.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
            //Debug.Log("raycast shot" + hit.collider.gameObject.name);
            if (hit.collider != null && hit.collider.gameObject.CompareTag("Draggable"))
            {
                //Debug.Log("Hit: " + hit.collider.gameObject.name);
                selectObject = hit.transform.gameObject;
            }
        }
    }
}
