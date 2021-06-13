using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadAsset : MonoBehaviour
{
    public GameObject Prefab;

    public AssetReference PrefabRef;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Instantiate(Prefab);

        var handle = PrefabRef.InstantiateAsync();//异步操作，不会阻塞
        yield return handle;

        var go = handle.Result;

        var handle1 = PrefabRef.InstantiateAsync();
        handle1.Completed += (go) => {
           var prefab = handle.Result;
        };

        // handle1.Completed += Loaded();
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
