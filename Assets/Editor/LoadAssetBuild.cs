//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class LoadAssetBuild : MonoBehaviour
//{
//    string url = "https://drive.google.com/uc?export=download&id=1pSZgu4jlgT6KMJo8DCmPvtBDkWl8Bk89";
//    // Start is called before the first frame update

//    public void ShowPicture()
//    {
//        WWW www = new WWW(url);
//        StartCoroutine(WebReq(www));
//    }
//    // Update is called once per frame
//    IEnumerator WebReq(WWW www)
//    {
//        yield return www;

//        while (www.isDone == false)
//        {
//            yield return www;
//        }

//        AssetBundle bundle = www.assetBundle;

//        if (www.error == null)
//        {
//            GameObject obj = (GameObject)bundle.LoadAsset("SP GIRLS");
//            Instantiate(obj); 
//        }
//        else
//        {
//            Debug.Log(www.error);
//        }
//    }
//    void Update()
//    {
        
//    }
//}
