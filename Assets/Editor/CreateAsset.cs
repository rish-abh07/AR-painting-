using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

public class CreateAsset : MonoBehaviour
{


    [MenuItem("Assets/Build AssetBundle")]
    [System.Obsolete]
    static void ExportResource()
    {
        string path = "Assets/AssetBundle/sp_girl.unity3d";
        Object[] selection = Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets);
        BuildPipeline.BuildAssetBundle(Selection.activeObject, selection, path,
                                       BuildAssetBundleOptions.CollectDependencies
                                     | BuildAssetBundleOptions.CompleteAssets, BuildTarget.Android);
    }
}

