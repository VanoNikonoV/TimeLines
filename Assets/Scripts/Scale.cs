using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public void ScaleGameObject()
    {
        this.transform.localScale = Vector3.one * 3;
    }
    
}
