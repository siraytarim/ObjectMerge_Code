using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeScript : MonoBehaviour
{
    private Vector2 mousePosition;
    private float offsetX;
    private float offsetY;
    public static bool mouseButtonReleased;

    private void onMouseDown()
    {
        mouseButtonReleased = false;
        offsetX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        offsetY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;

    }
    private void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x - offsetX, mousePosition.y - offsetY);
    }
    private void OnMouseUp()
    {
        mouseButtonReleased = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        string thisGameObjectName;
        string CollisionGameObjectName;

        thisGameObjectName = gameObject.name.Substring(0, name.IndexOf("_"));   //ilk kelime
        CollisionGameObjectName = collision.gameObject.name.Substring(0, name.IndexOf("_"));

        if (mouseButtonReleased && thisGameObjectName == "PlanetY" && thisGameObjectName == CollisionGameObjectName)
        {
            Instantiate(Resources.Load("ParentP_"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (mouseButtonReleased && thisGameObjectName == "PlanetY" && CollisionGameObjectName == "PlanetP")
        {
            Instantiate(Resources.Load("SandP_"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (mouseButtonReleased && thisGameObjectName == "PlanetY" && CollisionGameObjectName == "CyanPP")
        {
            Instantiate(Resources.Load("CyanP_"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (mouseButtonReleased && thisGameObjectName == "WaterP" && CollisionGameObjectName == "WhiteS")
        {
            Instantiate(Resources.Load("EarthP_"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (mouseButtonReleased && thisGameObjectName == "WaterP" && CollisionGameObjectName == "WaterP")
        {
            Instantiate(Resources.Load("CyanP_"), transform.position, Quaternion.identity);
            mouseButtonReleased = false;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}
