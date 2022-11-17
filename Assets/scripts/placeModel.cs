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
        spawnedObj = Instantiate(objToSpawn, new Vector3(31.4f, 0, -55.6f), Quaternion.Euler(0f, -122, 0f));
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
