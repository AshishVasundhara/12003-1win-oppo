using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{   
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 90 * Time.deltaTime * 2));
    }
}
