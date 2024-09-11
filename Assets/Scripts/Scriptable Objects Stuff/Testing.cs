using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] TestScriptableObject targetScriptableObject;

    void Start()
    {
        Debug.Log(targetScriptableObject.myString);
    }
}
