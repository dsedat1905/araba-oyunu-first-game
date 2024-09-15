using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moveCar : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    
	bool isPointerDown = false;
	float carSpeed = 0;

	public virtual void OnPointerUp(PointerEventData p)
	{
		isPointerDown = false;
	}
	
	public virtual void OnPointerDown(PointerEventData p)
	{
		isPointerDown = true;
	}
	
	public float accelarateCar()
	{
		if(isPointerDown == true)
	{
		carSpeed += 5f;
	}
		else
	{
		carSpeed = 0;
	}
		return carSpeed;
	}
}