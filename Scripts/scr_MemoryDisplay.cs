using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_MemoryDisplay : MonoBehaviour
{
    private Text textObject;
    // Start is called before the first frame update
    void Start()
    {
        textObject = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = UnityEngine.Profiling.Profiler.GetTotalAllocatedMemoryLong() / 1e+6f;
        string text = "Total Allocated Memory: " + x.ToString() + " MB";
        textObject.text = text;
    }
}
