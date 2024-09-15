using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
	public moveCar mvCar;
	public backCar bvCar;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


    private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
    // float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
 float s = CrossPlatformInputManager.GetAxis("Vertical");
  float v1 = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v1, handbrake);
#else
		s = Input.acceleration.x * 5;
		v = mvCar.accelarateCar();
		v1 = bvCar.accelarateCarBack();
		// h = rvCar.accelarateCarRight();
		// h = lvCar.accelarateCarLeft();
            m_Car.Move(h, v, v1, 0f);
#endif
        }
    }
}
