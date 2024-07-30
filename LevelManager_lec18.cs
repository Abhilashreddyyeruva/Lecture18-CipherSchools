using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform instatiatePos;
    // Start is called before the first frame update

    public CameraFollow cameraFollow;

    void Start()
    {
       GameObject go = Instantiate(ballPrefab,instatiatePos.position,Quaternion.identity);
        cameraFollow.target = go;
    }
}
