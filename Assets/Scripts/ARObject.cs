using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARObject : MonoBehaviour
{
    public GameObject text;
    public GameObject assets;
    
   // string url = "https://drive.google.com/uc?export=download&id=1pSZgu4jlgT6KMJo8DCmPvtBDkWl8Bk89";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPress()
    {
       // WWW www = new WWW(url);
        //StartCoroutine(WebReq(www));
        text.SetActive(false);
        
        assets.SetActive(true);
    }
    //IEnumerator WebReq(WWW www)
    //{
    //    yield return www;
        

    //    while (www.isDone == false)
    //    {
    //        yield return www;
    //    }

    //    AssetBundle bundle = www.assetBundle;

    //    if (www.error == null)
    //    {
    //        GameObject obj = (GameObject)bundle.LoadAsset("SP GIRLS");
    //        Debug.Log("Aggaya Mae agaya ");
    //        Instantiate(obj);
    //    }
    //    else
    //    {
    //        Debug.Log(www.error);
    //    }
    //}
}
