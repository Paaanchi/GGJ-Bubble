using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop2D : MonoBehaviour
{
    [SerializeField] Transform grabbedObject;
    [SerializeField] bool dragging = false;
    [SerializeField] LayerMask layer;

    Vector3 mousePosition;

    private void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D raycastHit2D = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, layer);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (raycastHit2D != false)
            {
                grabbedObject = raycastHit2D.transform;
                dragging = true;
            }
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            if(dragging) {
                grabbedObject.position = new Vector3(mousePosition.x, mousePosition.y, 0);
            }
        }
        else if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            dragging = false;
            grabbedObject = null;
        }
    }
}
