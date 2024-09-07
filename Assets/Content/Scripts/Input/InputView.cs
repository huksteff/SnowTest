using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DefaultNamespace
{
    public class InputView : MonoBehaviour
    {
        public event Action<Vector2> OnMove;
        public InputActionAsset PlayerInputAsset;

        public void Initialize()
        {
            PlayerInputAsset.Enable();

            PlayerInputAsset["Move"].performed += OnMoveInput;
        }

        public void Dispose()
        {
            PlayerInputAsset.Disable();

            PlayerInputAsset["Move"].performed -= OnMoveInput;
        }

        private void OnMoveInput(InputAction.CallbackContext ctx)
        {
            OnMove?.Invoke(ctx.ReadValue<Vector2>());
        }
    }
}