using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour
{
    void destroy()
    {
        GameObject clickedGameObject = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

        if (hitSprite == true)
        {
            clickedGameObject = hitSprite.transform.gameObject;
            if (clickedGameObject.tag == "Fly")
            {
                Destroy(clickedGameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            destroy();
        }

        // float rndX = Random.Range(-0.1f, 0.1f);
        // float rndY = Random.Range(-0.1f, 0.1f);
        // transform.Translate(rndX, rndY, 0);
    }
}
