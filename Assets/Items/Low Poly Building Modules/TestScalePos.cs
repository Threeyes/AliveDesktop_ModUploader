using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScalePos : MonoBehaviour
{

    public float scale = 2.5f;
    [ContextMenu("UpdatePos")]
    void UpdatePos()
    {
        foreach (Transform tfChild in transform)
        {
            tfChild.localPosition = new Vector3(tfChild.localPosition.x * scale, tfChild.localPosition.y, tfChild.localPosition.z * scale);
        }
    }
}
