using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Controls();
        SideBorder();
    }

    void Controls()
    {
        // Manage the inputs of the user and move the racket according to the position of the touch
        if (Input.GetMouseButton(0) || Input.touchCount > 0)
        {
            Vector3 screenPos = Input.mousePosition;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

            //Input.GetTouch(0).position.x
            transform.position = new Vector3(worldPos.x, transform.position.y);
        }
    }

    void SideBorder()
    {
        // Manage collision with screen sides
        var left = Camera.main.ScreenToWorldPoint(new Vector3(0, Camera.main.pixelHeight, Camera.main.nearClipPlane)).x;
        var right = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight, Camera.main.nearClipPlane)).x;
        var halfSize = spriteRenderer.bounds.size.x / 2;

        // Left side check
        if (transform.position.x - halfSize < left)
        {
            transform.position = new Vector3(left + halfSize, transform.position.y);
        }

        // Right side check
        else if (transform.position.x + halfSize > right)
        {
            transform.position  = new Vector3(right - halfSize, transform.position.y);
        }
   }
}
