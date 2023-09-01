using UnityEngine;

namespace PlayerTPAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {

        [Header("Output")]
        public PlayerTPAssetsInputs playerTPAssetsInputs;

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            playerTPAssetsInputs.MoveInput(virtualMoveDirection);
        }

        public void VirtualLookInput(Vector2 virtualLookDirection)
        {
            playerTPAssetsInputs.LookInput(virtualLookDirection);
        }

        public void VirtualJumpInput(bool virtualJumpState)
        {
            playerTPAssetsInputs.JumpInput(virtualJumpState);
        }

        public void VirtualSprintInput(bool virtualSprintState)
        {
            playerTPAssetsInputs.SprintInput(virtualSprintState);
        }
        
    }

}
