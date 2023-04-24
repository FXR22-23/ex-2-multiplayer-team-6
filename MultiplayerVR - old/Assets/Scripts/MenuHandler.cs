using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class MenuHandler : MonoBehaviour
{
    public void OnClickHost()
    {
        NetworkManager.Singleton.StartHost();
        Debug.Log("Yayyyyy hosttttt");
    }
    public void OnClickClient()
    {
        NetworkManager.Singleton.StartClient();
        Debug.Log("Yayyyyy clienttttttt");
    }
}
