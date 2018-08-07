using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = { 3,5,7,1,34,2,436,2 };
        for(int i = 0; i < array.Length; i++)
                {
          Debug.Log(array[i]);
        }

        for (int x = array.Length-1 ; x >= 0; x--)
         {
           Debug.Log(array[x]);
         }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
