using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class DisplayImageFromDrive : MonoBehaviour
{
    [SerializeField] private SetData[] setData;
   

    private int imagePlace;
   
    void Start()
    {
        imagePlace = 0;
        StartCoroutine(DownLoadImage());

    }

    
    private IEnumerator DownLoadImage()
    {
        for (int i = 0; i < setData.Length; i++)
        {
            UnityWebRequest request = UnityWebRequestTexture.GetTexture(setData[i].url);
            yield return request.Send();

            setData[i].Pair[0].GetComponent<Renderer>().material.mainTexture = DownloadHandlerTexture.GetContent(request);
            setData[i].Pair[1].GetComponent<Renderer>().material.mainTexture = DownloadHandlerTexture.GetContent(request);

            imagePlace = (imagePlace + 1) % setData.Length;
            
        }

    }

   
}
