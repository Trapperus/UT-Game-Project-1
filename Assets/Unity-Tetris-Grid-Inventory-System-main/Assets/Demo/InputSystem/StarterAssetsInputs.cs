using ProjectFiles.TetrisGrid;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StarterAssets
{
	
	public class StarterAssetsInputs : MonoBehaviour, IInteractInput, ICursorInput, IUseInput
	{
		public bool Interact
		{
			get => interact;
			set => InteractInput(value);
		}
		
		public bool Use
		{
			get => use;
			set => UseInput(value);
		}

		public Vector2 CursorPosition => cursorPosition;

		[Header("Character Input Values")]
		public Vector2 cursorPosition;
		
		public bool interact;
		public bool use;

		public void OnMousePosition(InputValue value)
		{
			MousePositionInput(value);
		}

		public void OnInteract(InputValue value)
		{
			InteractInput(value.isPressed);
		}
		
		public void OnUse(InputValue value)
		{
			UseInput(value.isPressed);
		}

		private void MousePositionInput(InputValue value)
		{
			cursorPosition = value.Get<Vector2>();
		}
		
		public void InteractInput(bool newInteractState)
		{
			interact = newInteractState;
		}
		
		public void UseInput(bool newUseState)
		{
			use = newUseState;
		}
	}
	
}