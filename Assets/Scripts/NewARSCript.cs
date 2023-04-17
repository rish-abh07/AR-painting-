using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using Vuforia;

public class NewARSCript : MonoBehaviour
{
    public string AssetName;
    private GameObject mBundleInstance = null;
    private ObserverBehaviour mObserverBehaviour;
    private AssetBundle bundle;
    private bool mAttached = false;
    void Start()
    {
        StartCoroutine(DownloadAndCache());
        mObserverBehaviour = GetComponent<ObserverBehaviour>();
        if (mObserverBehaviour)
        {
            mObserverBehaviour.gameObject.AddComponent<DefaultObserverEventHandler>();
        }
    }

    // Update is called once per frame
    IEnumerator DownloadAndCache()
    {
        while (!Caching.ready)
            yield return null;

        // example URL for retrieving bundle from a server
        string bundleURL = "https://drive.google.com/uc?export=download&id=1k1wGzvRx1TRuYWSi8Twkp5dYUg_TxVqx";
        using (UnityWebRequest mAssetBundle = UnityWebRequestAssetBundle.GetAssetBundle(bundleURL))
        {
            yield return mAssetBundle;
            if (mAssetBundle.error != null)
            {
                Debug.Log("yhaan tak toh poch gya ");

                throw new UnityException("mAssetBundle download had an error: " + mAssetBundle.error);
            }
                bundle = DownloadHandlerAssetBundle.GetContent(mAssetBundle);
            if (AssetName == "SP GIRLS")
            {
                LoadAssetToTarget();
            }
        }
    }

    private void LoadAssetToTarget()
    {
        mBundleInstance = Instantiate(bundle.LoadAsset(AssetName)) as GameObject;
        if (!mAttached && mBundleInstance)
        {
            // If bundle has been loaded, let's attach it to this target
            mBundleInstance.transform.parent = this.transform;
            mBundleInstance.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            mBundleInstance.transform.localPosition = new Vector3(0.0f, 0.15f, 0.0f);
            mBundleInstance.transform.gameObject.SetActive(true);
            mAttached = true;

        }
    }
}