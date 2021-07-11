using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;

		public int jumpCounter = 0;
		public bool sprint;

		public bool saiteE, saiteA, saiteD, saiteG, saiteH, saiteE1;

		public bool escape;

		[Header("Movement Settings")]
		public bool analogMovement;

#if !UNITY_IOS || !UNITY_ANDROID
		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;
#endif

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
		public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
		}

		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
		}

		public void OnSaiteE(InputValue value)
		{
			SaiteEInput(value.isPressed);
		}
		public void OnSaiteA(InputValue value)
		{
			SaiteAInput(value.isPressed);
		}
		public void OnSaiteD(InputValue value)
		{
			SaiteDInput(value.isPressed);
		}
		public void OnSaiteG(InputValue value)
		{
			SaiteGInput(value.isPressed);
		}
		public void OnSaiteH(InputValue value)
		{
			SaiteHInput(value.isPressed);
		}
		public void OnSaiteE1(InputValue value)
		{
			SaiteE1Input(value.isPressed);
		}

		public void onEscape(InputValue value){
			EscapeInput(value.isPressed);
		}		
#else
	// old input sys if we do decide to have it (most likely wont)...
#endif


		public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}

		public void SaiteEInput(bool newEInput)
		{
			saiteE = newEInput;
		}public void SaiteAInput(bool newEInput)
		{
			saiteA = newEInput;
		}public void SaiteDInput(bool newEInput)
		{
			saiteD = newEInput;
		}public void SaiteGInput(bool newEInput)
		{
			saiteG = newEInput;
		}public void SaiteHInput(bool newEInput)
		{
			saiteH = newEInput;
		}public void SaiteE1Input(bool newEInput)
		{
			saiteE1 = newEInput;
		}

		public void ResetJCounter()
		{
			jumpCounter = 0;
		}

		public void EscapeInput(bool newEscape){
			escape = newEscape;
			Debug.Log(escape);
		}

#if !UNITY_IOS || !UNITY_ANDROID

		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}

#endif

	}
	
}