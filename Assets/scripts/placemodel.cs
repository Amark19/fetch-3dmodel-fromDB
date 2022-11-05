using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placemodel : MonoBehaviour
{

    public string url;
    public string name_model ; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.GetComponent<loadassets>().webReq(url,name_model));
    }

}
