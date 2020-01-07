using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class playernetworking : MonoBehaviour
{
    public MonoBehaviour[] scripttoignore;

    PhotonView ph;
    // Start is called before the first frame update
    void Start()
    {
        ph = GetComponent<PhotonView>();
        if (!ph.IsMine)
        {
            foreach (var scripts in scripttoignore)
            {
                scripts.enabled = false;
            }
        }
    }

    
}
