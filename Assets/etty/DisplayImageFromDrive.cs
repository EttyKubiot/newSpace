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
    //[SerializeField] private GameObject[] stand1;
    //[SerializeField] private GameObject[] stand2;
    //Dictionary<GameObject, GameObject> keys = new Dictionary<GameObject, GameObject>();
    List<GameObject[]> stands = new List<GameObject[]>();
    //List<GameObject> set = new List<GameObject>();
    [SerializeField] private GameObject[] set;

    //void Start()
    //{
    //imagePlace = 0;
    //    for (int i = 0; i < keys.Count; i++)
    //    {
    //        keys.Add(stand1[i], stand2[i]);
    //    }
    //        StartCoroutine(DownLoadImage());

    //}

    //private IEnumerator DownLoadImage()
    //{
    // for(int i = 0; i < urlI.Length; i++)
    //    {
    //        UnityWebRequest request = UnityWebRequestTexture.GetTexture(urlI[i]);
    //        yield return request.Send();
    //        keys[stand1[i]].GetComponent<Renderer>().material.mainTexture = DownloadHandlerTexture.GetContent(request);

    //        //for (int b = 0; b < keys.Count; b++)
    //        //{



    //}

    //}

    //imagePlace++;


    //UnityWebRequest request2 = UnityWebRequestTexture.GetTexture(urlI[1]);
    //yield return request2.Send();

    //for (int i = 0; i < stand2.Length; i++)
    //{
    //    stand2[i].GetComponent<Renderer>().material.mainTexture = DownloadHandlerTexture.GetContent(request2);
    //}

    //}
}
