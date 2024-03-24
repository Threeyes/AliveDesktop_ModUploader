#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 将模型进行整体移动，以便适配其缩放值
/// </summary>
public class EditorChangeScale : MonoBehaviour
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
#endif