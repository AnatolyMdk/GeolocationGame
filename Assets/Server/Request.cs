using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Request : MonoBehaviour
{
    InputField LevelText;
    public Text ExpText;
    // string filePath = Path.Combine("Assets", "Server/API.json");

    void Start()
    {
        LevelText = GameObject.Find("Level Text").GetComponent<InputField>();
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            Debug.Log("Conectando...");
            yield return webRequest.SendWebRequest();
            if (webRequest.isNetworkError)
            {
                Debug.Log("Error: " + webRequest.error);
            } else
            {
                // Debug.Log(webRequest.downloadHandler.text);

            }
        }
    }

}
