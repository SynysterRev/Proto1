using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{

    #region Public Fields
    public delegate void DelegateCollision(GameObject go);
    public event DelegateCollision OncollisionPlayer;


    #endregion


    #region Private Fields
    [SerializeField]
    private float timerBeforeFall = 3.0f;
    private bool startCountdownFall = false;
    private float timer = 0.0f;

    #endregion


    #region Accessors



    #endregion


    #region MonoBehaviour Methods

    void Start()
    {

    }


    void Update()
    {
        if (startCountdownFall)
        {
            if (Time.time - timer >= timerBeforeFall)
            {
                startCountdownFall = false;
                if (OncollisionPlayer != null)
                    OncollisionPlayer(gameObject);
            }
        }
    }

    #endregion


    #region Private Methods
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<CharacterController>())
        {
            timer = Time.time;
            startCountdownFall = true;
        }
    }


    #endregion


    #region Public Methods



    #endregion


}
