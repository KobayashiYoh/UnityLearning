using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private GameObject player;
    private GameObject goal;
    private GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        goal = GameObject.Find("Goal");
        distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = (goal.transform.position.y - player.transform.position.y) * 50.0f;
        distance.GetComponent<Text>().text = "聖地マリージョアまで " + length.ToString("F0") + " m";
    }
}
