
namespace BallClicker
{
    using System;
    using UnityEngine;

    public class ZoneLose : MonoBehaviour
    {
        public static Action OnBallInLoss = delegate { };
        private void OnTriggerEnter2D( Collider2D collision)
        {

            collision.gameObject.TryGetComponent(out Ball _ball);
            OnBallInLoss();
            _ball.Death();
            Destroy(collision.gameObject);
        }
    }
}
