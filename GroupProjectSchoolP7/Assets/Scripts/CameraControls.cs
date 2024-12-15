using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    #region Variables
    public GameObject target; //Reference to the target fir the cam to follow

    private Vector3 positionOffset; //The positon offset btw the target and the cam
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        positionOffset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position + positionOffset;
    }
}


