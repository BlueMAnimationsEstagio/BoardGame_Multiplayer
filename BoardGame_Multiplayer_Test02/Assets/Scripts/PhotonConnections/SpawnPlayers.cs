using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    //public Transform spawnParent;

    //public Vector3 positionOne = new Vector3(-2f, 0.5f, 0f);
    //public Vector3 positionTwo = new Vector3(2f, 0.5f, 0f);

    public float minX = -17.86f;
    public float maxX = 17.86f;
    public float minZ = -18.59f;
    public float maxZ = 18.59f;

    //float randomX = Random.Range(minX, maxX);
    //float randomZ = Random.Range(minZ, maxZ);

    private void Start()
    {
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);

        Vector3 randomPosition = new Vector3(randomX, 0.58f, randomZ);
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    }


}
