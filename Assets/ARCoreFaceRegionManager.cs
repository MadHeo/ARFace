using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARCore;

public class ARCoreFaceRegionManager : MonoBehaviour
{
    public GameObject nosePrefab;
    public GameObject leftHeadPrefab;
    public GameObject rightHeadPrefab;

    ARFaceManager arFaceManager;
    ARSessionOrigin sessionOrigin;
    // Start is called before the first frame update
    void Start()
    {
        arFaceManager = GetComponent<ARFaceManager>();
        sessionOrigin = GetComponent<ARSessionOrigin>();
    }

    // Update is called once per frame
    void Update()
    {
        ARCoreFaceSubsystem subsystem = (ARCoreFaceSubsystem)arFaceManager.subsystem;
    }
}
