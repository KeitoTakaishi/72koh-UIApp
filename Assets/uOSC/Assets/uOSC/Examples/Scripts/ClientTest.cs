using UnityEngine;

namespace uOSC
{

[RequireComponent(typeof(uOscClient))]
public class ClientTest : MonoBehaviour
{
    private int id = 0;
    void Start()
    {
        
    }
    void Update()
    {
//        var client = GetComponent<uOscClient>();
//        client.Send("/uOSC/test", 10, "hoge", "hogehoge", 1.234f, 123f);
        if (Input.GetKey(KeyCode.A))
        {
            var client = GetComponent<uOscClient>();
            client.Send("/uOSC/test", id++);
        }
    }
}

}