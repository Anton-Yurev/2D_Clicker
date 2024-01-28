
namespace BallClicker
{
    using UnityEngine;

    public class ZoneLose : MonoBehaviour
    {
        private void OnTriggerEnter2D( Collider2D collision)
        {
            collision.gameObject.TryGetComponent(out Ball _ball); 
            _ball.Death();
            Destroy(collision.gameObject);
        }
    }
}
