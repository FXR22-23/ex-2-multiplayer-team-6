using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    private bool isClient = false;
    private bool initialized = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (!initialized && SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (isClient)
            {
                NetworkManager.Singleton.StartClient();
            }
            else
            {
                NetworkManager.Singleton.StartHost();
            }

            initialized = true;
        }
        
    }

    public void OnClickHost()
    {
        SceneManager.LoadScene(1);
    }
    public void OnClickClient()
    {
        isClient = true;
        SceneManager.LoadScene(1);
    }
}
