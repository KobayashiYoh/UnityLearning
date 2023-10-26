using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject blockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (float y = 2.0f; y < 4.4f; y += 0.8f)
        {
            for (float x = -6.4f; x < 7.2f; x += 1.0f)
            {
                GameObject gameObject = Instantiate(blockPrefab) as GameObject;
                gameObject.transform.position = new Vector2(x, y);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
