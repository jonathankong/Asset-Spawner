using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetSpawner : MonoBehaviour {

    public Vector3 position;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            createPreFab();
        }
    }

    void createPreFab()
    {
        GameObject myPreFabClone = Resources.Load("Box") as GameObject;
        Instantiate(myPreFabClone, position, Quaternion.identity);
    }
}
