using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downloadModel : MonoBehaviour
{

    public string url;
    public GameObject tap_to_btn;
    public string name_model;
    // Start is called before the first frame update

    void Start()
    {
        // if(name_model){
        //     Debug.Log("present");
        // }
        DownloadModel();
    }
    public void DownloadModel()
    {
        StartCoroutine(this.GetComponent<loadassets>().webReq(url, name_model));
        tap_to_btn.SetActive(true);
    }

}
