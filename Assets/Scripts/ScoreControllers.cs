
namespace BallClicker
{
    using UnityEngine;

    public class ScoreControllers : MonoBehaviour
    {
        [SerializeField]
        ScoreModel _scoreModel;

        [SerializeField]
        ScoreView _scoreView;
        public ScoreControllers(ScoreModel _scoreModel, ScoreView _scoreView)
        {
            this._scoreModel = _scoreModel;
            this._scoreView = _scoreView;
        }
        private void OnEnable()
        {
            ScoreModel.OnScoreUodate += UpdateInfo;
        }
        private void OnDisable()
        {
            ScoreModel.OnScoreUodate -= UpdateInfo;
        }
        private void UpdateInfo(int counterPoint)
        {
            _scoreView.UpdateText(counterPoint.ToString());
        }
    }
}
