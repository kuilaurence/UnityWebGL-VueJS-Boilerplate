using UnityEngine;
using System.Runtime.InteropServices;

public class JsTransferSDK : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string SendMsg2Web(string data);

    [DllImport("__Internal")]
    private static extern string debugLog(string param);

    void Start()
    {
        gameObject.GetComponent<TextMesh>().text = "6666";
#if !UNITY_EDITOR && UNITY_WEBGL
        WebGLInput.captureAllKeyboardInput = false;
#endif
    }
    //脚本挂载到名为WebGLListener的gameobject上   assets/下的包要替换    public/下的包也要替换
    public void SetText(string arg)
    {
        gameObject.GetComponent<TextMesh>().text = arg;
        debugLog("__Internal");
        SendMsg2Web("{\"action\":\"game\"}");
    }
}
