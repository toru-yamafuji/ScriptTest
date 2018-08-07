using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairetsu : MonoBehaviour {

    void Start()
    {
        string[] points = new string[5];

        points[0] = "今日は";
        points[1] = "西日本全域において";
        points[2] = "記録的な大雨となり";
        points[3] = "この豪雨は";
        points[4] = "しばらく続く模様です";

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }
    }
}
