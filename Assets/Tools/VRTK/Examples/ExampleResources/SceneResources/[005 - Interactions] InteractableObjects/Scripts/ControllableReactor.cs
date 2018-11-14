namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.UI;
    using VRTK.Controllables;

    public class ControllableReactor : MonoBehaviour
    {
        public VRTK_BaseControllable controllable;
        public Text displayText;
        public string outputOnMax = "Maximum Reached";
        public string outputOnMin = "Minimum Reached";

        public bool pushSent = false;
        public bool button = false;
        public bool isPressed = false; 

        protected virtual void OnEnable()
        {
            controllable = (controllable == null ? GetComponent<VRTK_BaseControllable>() : controllable);
            controllable.ValueChanged += ValueChanged;
            controllable.MaxLimitReached += MaxLimitReached;
            controllable.MinLimitReached += MinLimitReached;
        }

        protected virtual void ValueChanged(object sender, ControllableEventArgs e)
        {
            if (displayText != null)
            {
                displayText.text = e.value.ToString("F1");
            }
        }

        protected virtual void MaxLimitReached(object sender, ControllableEventArgs e)
        {
            if (outputOnMax != "")
            {
                Debug.Log(outputOnMax);
            }

            if (button && !pushSent)
            {
                isPressed = true;
            }
                
        }

        protected virtual void MinLimitReached(object sender, ControllableEventArgs e)
        {
            if (outputOnMin != "")
            {
                Debug.Log(outputOnMin);
            }

            if (button)
            {
                isPressed = false;
                if (pushSent)
                    pushSent = false;
            }
                
        }
    }
}