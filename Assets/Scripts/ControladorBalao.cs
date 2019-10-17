using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBalao : MonoBehaviour
{
	public float _velocidade = 10f;

	void Update()
	{
		transform.localPosition += Vector3.up * _velocidade;
	}

	public void Rebenta()
	{
		ControladorNivel.Instancia.RebentouBalao();
		Destroy(gameObject);
	}
}
