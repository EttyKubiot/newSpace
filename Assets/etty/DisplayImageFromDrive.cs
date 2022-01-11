using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DisplayImageFromDrive : MonoBehaviour
{
    [SerializeField] private string[] urlI;
    //private string DriveImageURL = "https://drive.google.com/u/0/uc?id=11YxceNYNHKKEidjF1El40msaoyNi84cg&export=download";
    //private string DriveImageURL2 = "https://drive.google.com/u/0/uc?id=1wdndhNdWoGEu_GK997NCbeAm5viJRI_5&export=download";
    private int imagePlace;
    [SerializeField] private GameObject [] stand1;
    [SerializeField] private GameObject[] stand2;
    void Start()
    {
        //imagePlace = 0;
       
        StartCoroutine(DownLoadImage());
      
    }

    private IEnumerator DownLoadImage()
    {
     
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(urlI[0]);
        yield return request.Send();
        //imagePlace++;
      
        for (int i = 0; i < stand1.Length; i++)
        {
          
          stand1[i].GetComponent<Renderer>().material.mainTexture = DownloadHandlerTexture.GetContent(request);
          
        }
        UnityWebRequest request2 = UnityWebRequestTexture.GetTexture(urlI[1]);
        yield return request2.Send();

        for (int i = 0; i < stand2.Length; i++)
        {
          stand2[i].GetComponent<Renderer>().material.mainTexture = DownloadHandlerTexture.GetContent(request2);
        }

    }
}
