using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{

	#region Public Fields



	#endregion


	#region Private Fields
	private Rigidbody rb = null;
	[SerializeField]
	private float speed = 0.0f;


	#endregion


	#region Accessors



	#endregion


	#region MonoBehaviour Methods

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.velocity = transform.forward * speed;
	}


	void Update()
	{

	}

	#endregion


	#region Private Methods



	#endregion


	#region Public Methods



	#endregion


}
