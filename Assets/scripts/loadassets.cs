using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class loadassets : MonoBehaviour
{
    public Text loading;
    AssetBundle assetBundle;
    placeModel placeM;
    public IEnumerator webReq(string url, string name)
    {
        WWW request = WWW.LoadFromCacheOrDownload(url, 0);
        while (!request.isDone)
        {
            // ProgressSlider.value = request.progress;
            // string persentateTemp = "" + request.progress * 100;
            // string[] strArray = persentateTemp.Split(char.Parse("."));
            // PersentageText.text = strArray[0] + "%";
            yield return null;
        }
        if (request.error == null)
        {
            assetBundle = request.assetBundle;
            placeM.updateModel(assetBundle.LoadAsset<GameObject>(name));
            // Instantiate(assetBundle.LoadAsset(name));
            // LoadingCanvas.SetActive(false);
            // MainCanvas.SetActive(true);
            Debug.Log("Success!!!");
        }
        else
        {
            Debug.Log("Error" + request.error);
        }
        yield return null;
    }

    //return gameObject


}
