using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapGenerator : MonoBehaviour
{

    #region Public Fields



    #endregion


    #region Private Fields
    [SerializeField]
    private GameObject prefabGround = null;
    [SerializeField]
    private int numberSpawnGround = 50;
    private GameObject lastGroundPlaced = null;

    #endregion


    #region Accessors



    #endregion


    #region MonoBehaviour Methods

    void Start()
    {
        GenerateMap();
    }


    void Update()
    {

    }

    #endregion


    #region Private Methods
    private void GenerateMap()
    {
        for (int i = 1; i <= numberSpawnGround; ++i)
        {
            GameObject go = Instantiate(prefabGround);
            go.transform.position = transform.position + transform.forward * i * go.GetComponent<Renderer>().bounds.size.z;
            go.GetComponent<Ground>().OncollisionPlayer += CollisionPlayer;
            lastGroundPlaced = go;
        }
    }

    private void CollisionPlayer(GameObject go)
    {
        go.transform.position = lastGroundPlaced.transform.position + transform.forward * go.GetComponent<Renderer>().bounds.size.z;
        lastGroundPlaced = go;
    }
    #endregion


    #region Public Methods



    #endregion


}
