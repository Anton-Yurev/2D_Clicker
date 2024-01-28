
namespace BallClicker
{
    using Unity.VisualScripting;
    using UnityEngine;

    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject _ballPrefab;


        [SerializeField]
        private float _timeOfNowBall = 0.5f;
        private float timer = 0;

        private Vector2 _pointOfSpawn;

        private float _pointOfSpawnX;
        private float _minPointOfSpawnX = -1.6f;
        private float _MaxPointOfSpawnX = 2.6f;
        private float _heightOfSpawn = 6;

        [SerializeField]
        private float _minTimeOfSpawn = 0.3f;
        [SerializeField]
        private float _maxTimeOfSpawn = 0.7f;

        void Update()
        {
            if ((timer += Time.deltaTime) >= _timeOfNowBall)
            {
                _pointOfSpawnX = Random.Range(_minPointOfSpawnX, _MaxPointOfSpawnX);
                _pointOfSpawn = new Vector2(_pointOfSpawnX, _heightOfSpawn);
                Instantiate(_ballPrefab, _pointOfSpawn, Quaternion.identity);
                timer = 0;
                _timeOfNowBall = Random.Range(_minTimeOfSpawn, _maxTimeOfSpawn);
            }

        }
    }
}
