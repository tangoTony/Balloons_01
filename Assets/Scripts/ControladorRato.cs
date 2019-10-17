using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorRato : MonoBehaviour
{
	Vector3 _currentMousePosition;
	bool _wasMouseClicked = false;

	private Camera _mainCamera = null;
	private Vector3 _rayStartPos = Vector3.zero;

	private const string kBalloonTag = "balloon";

	void Start()
	{
		_mainCamera = GetComponent<Camera>();
	}

	void Update()
	{
		_wasMouseClicked = Input.GetMouseButtonDown(0);
		_currentMousePosition = Input.mousePosition;

		if(_wasMouseClicked)
		{
			OnClick();
		}

	}

	void OnClick()
	{
		_rayStartPos = _mainCamera.ScreenToWorldPoint(_currentMousePosition);

		RaycastHit2D hit = Physics2D.Raycast(_rayStartPos, Vector3.forward);

		if ( hit.collider != null && hit.collider.tag == kBalloonTag )
		{
			ControladorBalao balao = hit.collider.gameObject.GetComponent<ControladorBalao>();

			if (balao != null)
			{
				balao.Rebenta();
			}
		}
	}
}
