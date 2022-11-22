using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeModel : MonoBehaviour
{

    GameObject objToSpawn;
    private GameObject spawnedObj;
    // Start is called before the first frame update
    public void clkToSpawn()
    {
        spawnedObj = Instantiate(objToSpawn, new Vector3(4.7f,0,-7.5f), Quaternion.Euler(0f, -122, 0f));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateModel(GameObject obj)
    {
        objToSpawn = obj;
    }
}
