using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour
{
    public float velocidad = 5f;
    PhotonView vista;
    private void Start()
    {
        vista = GetComponent<PhotonView>();
    }
    void Movimiento()
    {
        // El nuevo sistema usa Keyboard.current
        float x = 0f;
        float z = 0f;

        if (Keyboard.current.wKey.isPressed) z += 1;
        if (Keyboard.current.sKey.isPressed) z -= 1;
        if (Keyboard.current.aKey.isPressed) x -= 1;
        if (Keyboard.current.dKey.isPressed) x += 1;

        Vector3 direccion = new Vector3(x, 0, z).normalized;
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    void Update()
    {
        if(vista.IsMine)
        {
            Movimiento();
        }
    }
}
