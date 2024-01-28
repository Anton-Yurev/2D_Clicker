
namespace BallClicker
{
    using System;
    using UnityEngine;

    public class Ball : MonoBehaviour
    {
        public static Action OnBallDistroy = delegate { };

        [SerializeField]
        GameObject _effectPrafab;
        
        private SpriteRenderer spriteRenderer;
        private Transform _transform;

        private Color colorBall;
        private Vector2 _newScale;

        private float _minScaleX = 0.8f;
        private float _maxScaleX = 2f;
        private float newScale;
        private float _rComponentColor;
        private float _gComponentColor;
        private float _bComponentColor;
        private void Start()
        {
            NewColor();
            colorBall = new Color(_rComponentColor, _gComponentColor, _bComponentColor, 1);
            spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.color = colorBall;

            _transform = GetComponent<Transform>();
            newScale = UnityEngine.Random.Range(_minScaleX, _maxScaleX);
            _newScale = new Vector2(newScale, newScale);
            _transform.localScale = _newScale;
        }
        private void OnMouseDown()
        {
            OnBallDistroy();
            Death();
        }
        private void NewColor()
        {
            _rComponentColor = UnityEngine.Random.Range(0.1f, 1f);
            _gComponentColor = UnityEngine.Random.Range(0.1f, 1f);
            _bComponentColor = UnityEngine.Random.Range(0.1f, 1f);
        }
        public void Death()
        {
            Destroy(gameObject);
            _effectPrafab.GetComponent<ParticleSystem>().startColor = colorBall;
            Instantiate(_effectPrafab, _transform.position, _transform.rotation);
        }
    }
    
}
