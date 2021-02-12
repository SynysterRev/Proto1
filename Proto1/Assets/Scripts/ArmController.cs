using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class ArmController : MonoBehaviour
{

    #region Public Fields



    #endregion


    #region Private Fields
    private List<Vector3> positions = new List<Vector3> { new Vector3(1, 0, 0), new Vector3(-1, 0, 0), new Vector3(-1, 1, 0), new Vector3(1, 1, 0), };
    private int cpt = 0;
    #endregion


    #region Accessors



    #endregion


    #region MonoBehaviour Methods

    void Start()
    {

    }


    void Update()
    {

    }

    #endregion


    #region Private Methods
    private void ChangePosition(Vector3 position)
    {

    }


    #endregion


    #region Public Methods
    public void Click(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (cpt == 4)
            {
                cpt = 0;
            }
            Vector3 position = positions[cpt];
            position.z = transform.position.z;
            transform.position = position;
            cpt++;

        }
    }


    #endregion


}
