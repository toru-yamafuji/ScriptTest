using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int x = array.Length - 1; x >= 0; x--)
        {
            Debug.Log(array[x]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
