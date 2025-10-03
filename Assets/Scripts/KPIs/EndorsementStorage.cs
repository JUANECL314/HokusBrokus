using System.Collections.Generic;
using UnityEngine;

public static class EndorsementStorage
{
    private const string Key = "ENDORSEMENTS_LOG";

    public static void SaveLocal(List<EndorsementPayload> batch)
    {
        // Guardado simple como append a PlayerPrefs (demo). 
        // En producci�n usa JSON por-lotes en archivo o env�alo a tu backend.
        foreach (var e in batch)
        {
            Debug.Log($"[ENDORSE] {e.matchId} | {e.giverUserId} -> {e.receiverUserId} | {e.type} @ {e.unixTime}");
        }
        PlayerPrefs.SetInt(Key, PlayerPrefs.GetInt(Key, 0) + batch.Count);
        PlayerPrefs.Save();
    }

    public static int GetLocalCount() => PlayerPrefs.GetInt(Key, 0);
}
