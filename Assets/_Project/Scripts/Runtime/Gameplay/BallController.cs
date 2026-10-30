using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Project.Scripts.Runtime.Gameplay
{
    [RequireComponent(typeof(Rigidbody))]
    public class BallController : MonoBehaviour
    {
        [SerializeField] private float moveForce = 10f;
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI winText;
        [SerializeField] private int targetScore = 4;

        private Rigidbody _rb;
        private Vector2 _moveInput;
        private int score = 0;

        // 移除原本不合法的建構子，Unity 元件應透過 Inspector 或 Awake 初始化

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            if (winText != null) winText.text = "";
            UpdateScoreText();
        }

        private void Update()
        {
            var keyboard = Keyboard.current;
            if (keyboard == null)
            {
                _moveInput = Vector2.zero;
                return;
            }
            
            var horizontal = 0f;
            var vertical = 0f;

            if (keyboard.aKey.isPressed) horizontal -= 1f;
            if (keyboard.dKey.isPressed) horizontal += 1f;
            if (keyboard.sKey.isPressed) vertical -= 1f;
            if (keyboard.wKey.isPressed) vertical += 1f;

            _moveInput = Vector2.ClampMagnitude(new Vector2(horizontal, vertical), 1f);
        }

        private void FixedUpdate()
        {
            // 修正：補上遺漏的乘號 *
            var force = new Vector3(_moveInput.x, 0f, _moveInput.y) * moveForce;
            _rb.AddForce(force, ForceMode.Force);
        }

        // 當球碰到設定為 Trigger 的收集物時觸發
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PickUp")) // 確保你的收集物物件 Tag 是 "Pickup"
            {
                other.gameObject.SetActive(false); // 隱藏收集物
                score++;                           // 分數加 1
                UpdateScoreText();                 // 更新畫面上的分數
            }
        }

        // 更新分數文字與勝利提示
        private void UpdateScoreText()
        {
            if (scoreText != null)
            {
                scoreText.text = "Score: " + score;
            }

            if (score >= targetScore)
            {
                if (winText != null)
                {
                    winText.text = "You Win!";
                }
            }
        }
    }
}