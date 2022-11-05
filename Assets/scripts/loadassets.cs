using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class loadassets : MonoBehaviour
{
    public Text loading ; 
    
    public IEnumerator webReq(string url, string name){
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(url);
        // loading.text = "loading...";
        yield return www.SendWebRequest();
        // loading.text = "";
 
        if (www.result != UnityWebRequest.Result.Success) {
            Debug.Log(www.error);
        }
        else {
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
            Instantiate(bundle.LoadAsset(name));
        }
    }
}
