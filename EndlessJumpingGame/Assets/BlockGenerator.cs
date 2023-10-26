using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject blockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (float y = 0; y < 100f; y += 5f)
        {
            float x = Random.Range(-7.0f, 7.0f);
            GameObject gameObject = Instantiate(blockPrefab) as GameObject;
            gameObject.transform.position = new Vector2(x, y);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}