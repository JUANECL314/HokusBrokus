using Photon.Pun;
using UnityEngine;

public class SceneManagement : MonoBehaviour
{
    public void CaveLevel()
    {
        PhotonNetwork.LoadLevel("Cave");
    }
}
