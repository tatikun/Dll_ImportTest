using UnityEngine;
using System.Runtime.InteropServices;


public class test : MonoBehaviour
{
    [DllImport("DllToUnity")]
    private static extern int counter();

    [DllImport("DllToUnity")]
    private static extern void resetCount();

    // Start is called before the first frame update
    void Start()
    {
        resetCount();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(counter());
    }
}
