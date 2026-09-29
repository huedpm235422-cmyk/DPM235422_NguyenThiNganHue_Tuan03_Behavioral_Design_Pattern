using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Hue_Tuan3_State_DP
{
    public class Context
    {
        private IState _currentState;

        public Context(IState initialState)
        {
            _currentState = initialState;
            Console.WriteLine($"Context: Khởi tạo với {initialState.GetType().Name}.");
        }

        public void TransitionTo(IState state)
        {
            Console.WriteLine($"Context: Chuyển đổi trạng thái sang {state.GetType().Name}.");
            _currentState = state;
        }

        public void Request()
        {
            _currentState.Handle(this);
        }
    }
}
