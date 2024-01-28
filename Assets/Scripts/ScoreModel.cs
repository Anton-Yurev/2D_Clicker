
namespace BallClicker
{
    using System;
    using UnityEngine;
    public class ScoreModel : MonoBehaviour
    {
        public static Action<int> OnScoreUodate = delegate { };
        private int _counterPoint;
        private void Start()
        {
            _counterPoint = 0;
        }

        public void AddPoint()
        {
            _counterPoint++;
            OnScoreUodate(_counterPoint);
        }
        private void OnEnable()
        {
            Ball.OnBallDistroy += AddPoint;
        }
        private void OnDisable()
        {
            Ball.OnBallDistroy -= AddPoint;
        }
    }
}
