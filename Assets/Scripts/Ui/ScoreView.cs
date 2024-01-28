
namespace BallClicker
{
    using UnityEngine;
    using UnityEngine.UI;

    public class ScoreView : MonoBehaviour
    {
        Text _text;
        private void Start()
        {
            _text = GetComponent<Text>();
        }

        public void UpdateText(string text)
        {
            _text.text = text;
        }
        
    }
}
