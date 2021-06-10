using UnityEngine;

namespace CustomUINavigation
{
    public static class InputUtility
    {
        public static Vector3 GetDPADStyleAxisInput(bool roundToInt = false)
        {
            Vector3 axisInput = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            bool ignoreXAxis = Mathf.Abs(axisInput.x) < Mathf.Abs(axisInput.y);
            axisInput.x = ignoreXAxis ? 0 : axisInput.x;
            axisInput.y = !ignoreXAxis ? 0 : axisInput.y;

            if (roundToInt)
            {
                axisInput.x = Mathf.RoundToInt(axisInput.x);
                axisInput.y = Mathf.RoundToInt(axisInput.y);
            }

            return axisInput;
        }
    }
}