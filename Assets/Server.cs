//using Unity.Networking.Transport;
using UnityEngine;

public class Server : MonoBehaviour
{
    public static Server Instance { set; get; }
    private void Awake()
    {
        Instance = this;
    }

   // public NetworkDriver;
}
