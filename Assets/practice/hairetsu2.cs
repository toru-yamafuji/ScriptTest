using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairetsu2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] points = { 10, 20, 30, 40, 50, 60, 70 };


        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] > 50)
            {
                Debug.Log(points[i]);
            }
        }
    }

}
