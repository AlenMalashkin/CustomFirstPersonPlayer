using Code.Input;
using Code.StaticData.PlayerStaticData;
using UnityEngine;

namespace Code.FirstPersonPlayer
{
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerCamera))]
    [RequireComponent(typeof(PlayerJump))]
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerStaticData playerStaticData;
        [SerializeField] private PlayerMovement playerMovement;
        [SerializeField] private PlayerCamera playerCamera;
        [SerializeField] private PlayerJump playerJump;

        private IInputService _input;
        
        private void Awake()
        {
            _input = new DesctopInputService();
            _input.Enable();

            playerMovement.Init(_input);
            playerCamera.Init(_input);
            playerJump.Init(_input);
        }

        private void Update()
        {
            MovementLogic();
            JumpAndGravityLogic();
        }

        private void LateUpdate()
        {
            CameraLogic();
        }

        private void MovementLogic()
        {
            playerMovement.Move(playerStaticData.MoveSpeed,
                playerStaticData.SprintSpeed,
                playerStaticData.SpeedChangeRate);
        }

        private void JumpAndGravityLogic()
        {
            playerJump.GroundedCheck(playerStaticData.GroundedOffset,
                playerStaticData.GroundedRadius,
                playerStaticData.GroundLayers);

            playerJump.JumpAndApplyGravity(playerStaticData.JumpHeight,
                playerStaticData.Gravity,
                playerStaticData.JumpTimeout);
        }

        private void CameraLogic()
        {
            playerCamera.CameraRotation(playerStaticData.RotationSpeed,
                playerStaticData.TopClamp,
                playerStaticData.BottomClamp);
        }
    }
}