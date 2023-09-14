using UnityEngine;

namespace Code.StaticData.PlayerStaticData
{
    [CreateAssetMenu(fileName = "PlayerStaticData", menuName = "Player Static Data", order = 0)]
    public class PlayerStaticData : ScriptableObject
    {
        [Header("Player Movement")]
        [Tooltip("Move speed of the character in m/s")]
        [SerializeField] private float moveSpeed = 4.0f;
        [Tooltip("Sprint speed of the character in m/s")]
        [SerializeField] private float sprintSpeed = 6.0f;
        [Tooltip("Rotation speed of the character")]
        [SerializeField] private float rotationSpeed = 1.0f;
        [Tooltip("Acceleration and deceleration")]
        [SerializeField] private float speedChangeRate = 10.0f;

        [Space(10)]
        [Tooltip("The height the player can jump")]
        [SerializeField] private float jumpHeight = 1.2f;
        [Tooltip("The character uses its own gravity value. The engine default is -9.81f")]
        [SerializeField] private float gravity = -15.0f;

        [Space(10)]
        [Tooltip("Time required to pass before being able to jump again. Set to 0f to instantly jump again")]
        [SerializeField] private float jumpTimeout = 0.1f;

        [Header("Player Grounded")]
        [Tooltip("Useful for rough ground")]
        [SerializeField] private float groundedOffset = -0.14f;
        [Tooltip("The radius of the grounded check. Should match the radius of the CharacterController")]
        [SerializeField] private float groundedRadius = 0.5f;
        [Tooltip("What layers the character uses as ground")]
        [SerializeField] private LayerMask groundLayers;

        [Header("Cinemachine")]
        [Tooltip("How far in degrees can you move the camera up")]
        [SerializeField] private float topClamp = 90.0f;
        [Tooltip("How far in degrees can you move the camera down")]
        [SerializeField] private float bottomClamp = -90.0f;

        public float MoveSpeed => moveSpeed;
        public float SprintSpeed => sprintSpeed;
        public float RotationSpeed => rotationSpeed;
        public float SpeedChangeRate => speedChangeRate;
        public float JumpHeight => jumpHeight;
        public float Gravity => gravity;
        public float JumpTimeout => jumpTimeout;
        public float GroundedOffset => groundedOffset;
        public float GroundedRadius => groundedRadius;
        public LayerMask GroundLayers => groundLayers;
        public float TopClamp => topClamp;
        public float BottomClamp => bottomClamp;
    }
}