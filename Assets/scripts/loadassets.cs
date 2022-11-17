using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class loadassets : MonoBehaviour
{
    public Slider ProgressSlider;
    public Text PercentageText ;
    public GameObject LoadingCanvas;
    public GameObject MainCanvas;
    public IEnumerator webReq(string url, string name)
    {
        WWW request = WWW.LoadFromCacheOrDownload(url, 0);
        while (!request.isDone)
        {
            ProgressSlider.value = request.progress;
            string persentateTemp = "" + request.progress * 100;
            string[] strArray = persentateTemp.Split(char.Parse("."));
            PercentageText.text = strArray[0] + "%";
            // Debug.Log(strArray[0] + "%");
            yield return null;
        }
        if (request.error == null)
        {
            ProgressSlider.value = 1;
            PercentageText.text = "100%";
            AssetBundle assetBundle = request.assetBundle;
            LoadingCanvas.SetActive(false);
            this.GetComponent<placeModel>().updateModel(assetBundle.LoadAsset<GameObject>(name));
            MainCanvas.SetActive(true);
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
